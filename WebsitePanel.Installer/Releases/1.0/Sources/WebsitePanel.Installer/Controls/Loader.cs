// Copyright (c) 2010, SMB SAAS Systems Inc.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  SMB SAAS Systems Inc.  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.IO;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;

using WebsitePanel.Installer.Services;
using WebsitePanel.Installer.Common;

namespace WebsitePanel.Installer.Controls
{
	/// <summary>
	/// Loader form.
	/// </summary>
	internal partial class Loader : Form
	{
		private const int ChunkSize = 262144;
		private Thread thread;
		private AppContext appContext;
		private string localFile;
		private string remoteFile;
		private string componentCode;
		private string version;
		private InstallerService service;

		public Loader()
		{
			InitializeComponent();
			this.DialogResult = DialogResult.Cancel;
		}

		public Loader(AppContext context, string remoteFile):this()
		{
			this.appContext = context;
			this.remoteFile = remoteFile;
			Start();
		}

		public Loader(AppContext context, string localFile, string componentCode, string version )	: this()
		{
			this.appContext = context;
			this.localFile = localFile;
			this.componentCode = componentCode;
			this.version = version;
			Start();
		}

		private void Start()
		{
			thread = new Thread(new ThreadStart(ShowProcess));
			thread.Start();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Log.WriteInfo("Execution was canceled by user");
			Close();
		}

		/// <summary>
		/// Displays process progress.
		/// </summary>
		public void ShowProcess()
		{
			progressBar.Value = 0;
			try
			{
				service = appContext.AppForm.WebService;
				string dataFolder = FileUtils.GetDataDirectory();
				string tmpFolder = FileUtils.GetTempDirectory();
				
				if (!Directory.Exists(dataFolder))
				{
					Directory.CreateDirectory(dataFolder);
					Log.WriteInfo("Data directory created");
				}

				if (Directory.Exists(tmpFolder))
				{
					FileUtils.DeleteTempDirectory();
				}
				
				if (!Directory.Exists(tmpFolder))
				{
					Directory.CreateDirectory(tmpFolder);
					Log.WriteInfo("Tmp directory created");
				}

				string fileToDownload = null;
				if (!string.IsNullOrEmpty(localFile))
				{
					fileToDownload = localFile;
				}
				else
				{
					fileToDownload = Path.GetFileName(remoteFile);
				}

				string destinationFile = Path.Combine(dataFolder, fileToDownload);
				string tmpFile = Path.Combine(tmpFolder, fileToDownload);

				
				//check whether file already downloaded
				if (!File.Exists(destinationFile))
				{
					if ( string.IsNullOrEmpty(remoteFile) )
					{
						//need to get remote file name
						lblProcess.Text = "Connecting...";
						progressBar.Value = 0;
						DataSet ds = service.GetReleaseFileInfo(componentCode, version);
						progressBar.Value = 100;
						if (ds != null &&
							ds.Tables.Count > 0 &&
							ds.Tables[0].Rows.Count > 0)
						{
							DataRow row = ds.Tables[0].Rows[0];
							remoteFile = row["FullFilePath"].ToString();
							fileToDownload = Path.GetFileName(remoteFile);
							destinationFile = Path.Combine(dataFolder, fileToDownload);
							tmpFile = Path.Combine(tmpFolder, fileToDownload);
						}
						else
						{
							throw new Exception("Installer not found"); 
						}
					}
					
					// download file to tmp folder
					lblProcess.Text = "Downloading setup files...";
					progressBar.Value = 0;
					DownloadFile(remoteFile, tmpFile, progressBar);
					progressBar.Value = 100;
					
					// copy downloaded file to data folder
					lblProcess.Text = "Copying setup files...";
					progressBar.Value = 0;
					// Ensure that the target does not exist.
					if (File.Exists(destinationFile))
						FileUtils.DeleteFile(destinationFile);
					File.Move(tmpFile, destinationFile);
					progressBar.Value = 100;
				}

				// unzip file
				lblProcess.Text = "Please wait while Setup prepares the necessary files...";
				progressBar.Value = 0;
				UnzipFile(destinationFile, tmpFolder, progressBar);
				progressBar.Value = 100;

				this.DialogResult = DialogResult.OK;
				this.Close();
			}
			catch (Exception ex)
			{
				if (Utils.IsThreadAbortException(ex))
					return;

				Log.WriteError("Installer error", ex);
				appContext.AppForm.ShowError(ex);
				this.DialogResult = DialogResult.Abort;
				this.Close();
			}
		}

		private void DownloadFile(string sourceFile, string destinationFile, ProgressBar progressBar)
		{
			try
			{
				Log.WriteStart("Downloading file");
				Log.WriteInfo(string.Format("Downloading file \"{0}\" to \"{1}\"", sourceFile, destinationFile));
				lblValue.Text = string.Empty;
				long downloaded = 0;
				long fileSize = service.GetFileSize(sourceFile);
				if (fileSize == 0)
				{
					throw new FileNotFoundException("Service returned empty file.", sourceFile);
				}

				byte[] content;

				while (downloaded < fileSize)
				{
					content = service.GetFileChunk(sourceFile, (int)downloaded, ChunkSize);
					if (content == null)
					{
						throw new FileNotFoundException("Service returned NULL file content.", sourceFile);
					}
					FileUtils.AppendFileContent(destinationFile, content);
					downloaded += content.Length;
					//update progress bar
					lblValue.Text = string.Format("{0} KB of {1} KB", downloaded / 1024, fileSize / 1024);
					progressBar.Value = Convert.ToInt32((downloaded * 100) / fileSize);

					if (content.Length < ChunkSize)
						break;
				}
				lblValue.Text = string.Empty;
				Log.WriteEnd(string.Format("Downloaded {0} bytes", downloaded));
			}
			catch (Exception ex)
			{
				if (Utils.IsThreadAbortException(ex))
					return;
				
				throw;
			}
		}

		private void UnzipFile(string zipFile, string destFolder, ProgressBar progressBar)
		{
			try
			{
				int val = 0;
				Log.WriteStart("Unzipping file");
				Log.WriteInfo(string.Format("Unzipping file \"{0}\" to the folder \"{1}\"", zipFile, destFolder));

				long zipSize = 0;
				using (ZipFile zip = ZipFile.Read(zipFile))
				{
					foreach (ZipEntry entry in zip)
					{
						if (!entry.IsDirectory)
							zipSize += entry.UncompressedSize;
					}
				}

				progressBar.Minimum = 0;
				progressBar.Maximum = 100;
				progressBar.Value = 0;

				long unzipped = 0;
				using (ZipFile zip = ZipFile.Read(zipFile))
				{
					foreach (ZipEntry entry in zip)
					{
						entry.Extract(destFolder, ExtractExistingFileAction.OverwriteSilently);  
						if (!entry.IsDirectory)
							unzipped += entry.UncompressedSize;

						if (zipSize != 0)
						{
							val = Convert.ToInt32(unzipped * 100 / zipSize);
							lblValue.Text = string.Format("{0}%", val);
							progressBar.Value = val;
						}
					}
				}

				lblValue.Text = "100%";
				Log.WriteEnd("Unzipped file");
			}
			catch (Exception ex)
			{
				if (Utils.IsThreadAbortException(ex))
					return;

				throw;
			}
		}

		private void OnLoaderFormClosing(object sender, FormClosingEventArgs e)
		{
			if (this.DialogResult == DialogResult.Cancel && this.thread != null)
			{
				if (this.thread.IsAlive)
				{
					this.thread.Abort();
				}
				this.thread.Join();
			}
		}
	}
}