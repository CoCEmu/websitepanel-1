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

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.1873
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by wsdl, Version=2.0.50727.1432.
// 
namespace WebsitePanel.EnterpriseServer {
    using System.Diagnostics;
    using System.Web.Services;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System;
    using System.Xml.Serialization;
	using WebsitePanel.Providers.ResultObjects;
	using WebsitePanel.Providers.WebAppGallery;
	using WebsitePanel.Providers.Common;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="esWebApplicationGallerySoap", Namespace="http://tempuri.org/")]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ResultObject))]
    public partial class esWebApplicationGallery : Microsoft.Web.Services3.WebServicesClientProtocol {
        
        private System.Threading.SendOrPostCallback GetGalleryApplicationsByServiceIdOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGalleryApplicationsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGalleryCategoriesOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGalleryApplicationDetailsOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGalleryApplicationParamsOperationCompleted;
        
        private System.Threading.SendOrPostCallback InstallOperationCompleted;
        
        private System.Threading.SendOrPostCallback GetGalleryApplicationStatusOperationCompleted;
        
        /// <remarks/>
        public esWebApplicationGallery() {
            this.Url = "http://localhost:1625/esWebApplicationGallery.asmx";
        }
        
        /// <remarks/>
        public event GetGalleryApplicationsByServiceIdCompletedEventHandler GetGalleryApplicationsByServiceIdCompleted;
        
        /// <remarks/>
        public event GetGalleryApplicationsCompletedEventHandler GetGalleryApplicationsCompleted;
        
        /// <remarks/>
        public event GetGalleryCategoriesCompletedEventHandler GetGalleryCategoriesCompleted;
        
        /// <remarks/>
        public event GetGalleryApplicationDetailsCompletedEventHandler GetGalleryApplicationDetailsCompleted;
        
        /// <remarks/>
        public event GetGalleryApplicationParamsCompletedEventHandler GetGalleryApplicationParamsCompleted;
        
        /// <remarks/>
        public event InstallCompletedEventHandler InstallCompleted;
        
        /// <remarks/>
        public event GetGalleryApplicationStatusCompletedEventHandler GetGalleryApplicationStatusCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGalleryApplicationsByServiceId", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GalleryApplicationsResult GetGalleryApplicationsByServiceId(int serviceId) {
            object[] results = this.Invoke("GetGalleryApplicationsByServiceId", new object[] {
                        serviceId});
            return ((GalleryApplicationsResult)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetGalleryApplicationsByServiceId(int serviceId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetGalleryApplicationsByServiceId", new object[] {
                        serviceId}, callback, asyncState);
        }
        
        /// <remarks/>
        public GalleryApplicationsResult EndGetGalleryApplicationsByServiceId(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((GalleryApplicationsResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetGalleryApplicationsByServiceIdAsync(int serviceId) {
            this.GetGalleryApplicationsByServiceIdAsync(serviceId, null);
        }
        
        /// <remarks/>
        public void GetGalleryApplicationsByServiceIdAsync(int serviceId, object userState) {
            if ((this.GetGalleryApplicationsByServiceIdOperationCompleted == null)) {
                this.GetGalleryApplicationsByServiceIdOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGalleryApplicationsByServiceIdOperationCompleted);
            }
            this.InvokeAsync("GetGalleryApplicationsByServiceId", new object[] {
                        serviceId}, this.GetGalleryApplicationsByServiceIdOperationCompleted, userState);
        }
        
        private void OnGetGalleryApplicationsByServiceIdOperationCompleted(object arg) {
            if ((this.GetGalleryApplicationsByServiceIdCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGalleryApplicationsByServiceIdCompleted(this, new GetGalleryApplicationsByServiceIdCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGalleryApplications", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GalleryApplicationsResult GetGalleryApplications(int packageId, string categoryId) {
            object[] results = this.Invoke("GetGalleryApplications", new object[] {
                        packageId,
                        categoryId});
            return ((GalleryApplicationsResult)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetGalleryApplications(int packageId, string categoryId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetGalleryApplications", new object[] {
                        packageId,
                        categoryId}, callback, asyncState);
        }
        
        /// <remarks/>
        public GalleryApplicationsResult EndGetGalleryApplications(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((GalleryApplicationsResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetGalleryApplicationsAsync(int packageId, string categoryId) {
            this.GetGalleryApplicationsAsync(packageId, categoryId, null);
        }
        
        /// <remarks/>
        public void GetGalleryApplicationsAsync(int packageId, string categoryId, object userState) {
            if ((this.GetGalleryApplicationsOperationCompleted == null)) {
                this.GetGalleryApplicationsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGalleryApplicationsOperationCompleted);
            }
            this.InvokeAsync("GetGalleryApplications", new object[] {
                        packageId,
                        categoryId}, this.GetGalleryApplicationsOperationCompleted, userState);
        }
        
        private void OnGetGalleryApplicationsOperationCompleted(object arg) {
            if ((this.GetGalleryApplicationsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGalleryApplicationsCompleted(this, new GetGalleryApplicationsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGalleryCategories", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GalleryCategoriesResult GetGalleryCategories(int packageId) {
            object[] results = this.Invoke("GetGalleryCategories", new object[] {
                        packageId});
            return ((GalleryCategoriesResult)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetGalleryCategories(int packageId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetGalleryCategories", new object[] {
                        packageId}, callback, asyncState);
        }
        
        /// <remarks/>
        public GalleryCategoriesResult EndGetGalleryCategories(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((GalleryCategoriesResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetGalleryCategoriesAsync(int packageId) {
            this.GetGalleryCategoriesAsync(packageId, null);
        }
        
        /// <remarks/>
        public void GetGalleryCategoriesAsync(int packageId, object userState) {
            if ((this.GetGalleryCategoriesOperationCompleted == null)) {
                this.GetGalleryCategoriesOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGalleryCategoriesOperationCompleted);
            }
            this.InvokeAsync("GetGalleryCategories", new object[] {
                        packageId}, this.GetGalleryCategoriesOperationCompleted, userState);
        }
        
        private void OnGetGalleryCategoriesOperationCompleted(object arg) {
            if ((this.GetGalleryCategoriesCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGalleryCategoriesCompleted(this, new GetGalleryCategoriesCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGalleryApplicationDetails", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GalleryApplicationResult GetGalleryApplicationDetails(int packageId, string applicationId) {
            object[] results = this.Invoke("GetGalleryApplicationDetails", new object[] {
                        packageId,
                        applicationId});
            return ((GalleryApplicationResult)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetGalleryApplicationDetails(int packageId, string applicationId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetGalleryApplicationDetails", new object[] {
                        packageId,
                        applicationId}, callback, asyncState);
        }
        
        /// <remarks/>
        public GalleryApplicationResult EndGetGalleryApplicationDetails(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((GalleryApplicationResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetGalleryApplicationDetailsAsync(int packageId, string applicationId) {
            this.GetGalleryApplicationDetailsAsync(packageId, applicationId, null);
        }
        
        /// <remarks/>
        public void GetGalleryApplicationDetailsAsync(int packageId, string applicationId, object userState) {
            if ((this.GetGalleryApplicationDetailsOperationCompleted == null)) {
                this.GetGalleryApplicationDetailsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGalleryApplicationDetailsOperationCompleted);
            }
            this.InvokeAsync("GetGalleryApplicationDetails", new object[] {
                        packageId,
                        applicationId}, this.GetGalleryApplicationDetailsOperationCompleted, userState);
        }
        
        private void OnGetGalleryApplicationDetailsOperationCompleted(object arg) {
            if ((this.GetGalleryApplicationDetailsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGalleryApplicationDetailsCompleted(this, new GetGalleryApplicationDetailsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGalleryApplicationParams", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public DeploymentParametersResult GetGalleryApplicationParams(int packageId, string applicationId) {
            object[] results = this.Invoke("GetGalleryApplicationParams", new object[] {
                        packageId,
                        applicationId});
            return ((DeploymentParametersResult)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetGalleryApplicationParams(int packageId, string applicationId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetGalleryApplicationParams", new object[] {
                        packageId,
                        applicationId}, callback, asyncState);
        }
        
        /// <remarks/>
        public DeploymentParametersResult EndGetGalleryApplicationParams(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((DeploymentParametersResult)(results[0]));
        }
        
        /// <remarks/>
        public void GetGalleryApplicationParamsAsync(int packageId, string applicationId) {
            this.GetGalleryApplicationParamsAsync(packageId, applicationId, null);
        }
        
        /// <remarks/>
        public void GetGalleryApplicationParamsAsync(int packageId, string applicationId, object userState) {
            if ((this.GetGalleryApplicationParamsOperationCompleted == null)) {
                this.GetGalleryApplicationParamsOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGalleryApplicationParamsOperationCompleted);
            }
            this.InvokeAsync("GetGalleryApplicationParams", new object[] {
                        packageId,
                        applicationId}, this.GetGalleryApplicationParamsOperationCompleted, userState);
        }
        
        private void OnGetGalleryApplicationParamsOperationCompleted(object arg) {
            if ((this.GetGalleryApplicationParamsCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGalleryApplicationParamsCompleted(this, new GetGalleryApplicationParamsCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/Install", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public StringResultObject Install(int packageId, string webAppId, string siteName, string virtualDir, DeploymentParameter[] parameters) {
            object[] results = this.Invoke("Install", new object[] {
                        packageId,
                        webAppId,
                        siteName,
                        virtualDir,
                        parameters});
            return ((StringResultObject)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginInstall(int packageId, string webAppId, string siteName, string virtualDir, DeploymentParameter[] parameters, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("Install", new object[] {
                        packageId,
                        webAppId,
                        siteName,
                        virtualDir,
                        parameters}, callback, asyncState);
        }
        
        /// <remarks/>
        public StringResultObject EndInstall(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((StringResultObject)(results[0]));
        }
        
        /// <remarks/>
        public void InstallAsync(int packageId, string webAppId, string siteName, string virtualDir, DeploymentParameter[] parameters) {
            this.InstallAsync(packageId, webAppId, siteName, virtualDir, parameters, null);
        }
        
        /// <remarks/>
        public void InstallAsync(int packageId, string webAppId, string siteName, string virtualDir, DeploymentParameter[] parameters, object userState) {
            if ((this.InstallOperationCompleted == null)) {
                this.InstallOperationCompleted = new System.Threading.SendOrPostCallback(this.OnInstallOperationCompleted);
            }
            this.InvokeAsync("Install", new object[] {
                        packageId,
                        webAppId,
                        siteName,
                        virtualDir,
                        parameters}, this.InstallOperationCompleted, userState);
        }
        
        private void OnInstallOperationCompleted(object arg) {
            if ((this.InstallCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.InstallCompleted(this, new InstallCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/GetGalleryApplicationStatus", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public GalleryWebAppStatus GetGalleryApplicationStatus(int packageId, string webAppId) {
            object[] results = this.Invoke("GetGalleryApplicationStatus", new object[] {
                        packageId,
                        webAppId});
            return ((GalleryWebAppStatus)(results[0]));
        }
        
        /// <remarks/>
        public System.IAsyncResult BeginGetGalleryApplicationStatus(int packageId, string webAppId, System.AsyncCallback callback, object asyncState) {
            return this.BeginInvoke("GetGalleryApplicationStatus", new object[] {
                        packageId,
                        webAppId}, callback, asyncState);
        }
        
        /// <remarks/>
        public GalleryWebAppStatus EndGetGalleryApplicationStatus(System.IAsyncResult asyncResult) {
            object[] results = this.EndInvoke(asyncResult);
            return ((GalleryWebAppStatus)(results[0]));
        }
        
        /// <remarks/>
        public void GetGalleryApplicationStatusAsync(int packageId, string webAppId) {
            this.GetGalleryApplicationStatusAsync(packageId, webAppId, null);
        }
        
        /// <remarks/>
        public void GetGalleryApplicationStatusAsync(int packageId, string webAppId, object userState) {
            if ((this.GetGalleryApplicationStatusOperationCompleted == null)) {
                this.GetGalleryApplicationStatusOperationCompleted = new System.Threading.SendOrPostCallback(this.OnGetGalleryApplicationStatusOperationCompleted);
            }
            this.InvokeAsync("GetGalleryApplicationStatus", new object[] {
                        packageId,
                        webAppId}, this.GetGalleryApplicationStatusOperationCompleted, userState);
        }
        
        private void OnGetGalleryApplicationStatusOperationCompleted(object arg) {
            if ((this.GetGalleryApplicationStatusCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.GetGalleryApplicationStatusCompleted(this, new GetGalleryApplicationStatusCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    public delegate void GetGalleryApplicationsByServiceIdCompletedEventHandler(object sender, GetGalleryApplicationsByServiceIdCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGalleryApplicationsByServiceIdCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGalleryApplicationsByServiceIdCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GalleryApplicationsResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GalleryApplicationsResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    public delegate void GetGalleryApplicationsCompletedEventHandler(object sender, GetGalleryApplicationsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGalleryApplicationsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGalleryApplicationsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GalleryApplicationsResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GalleryApplicationsResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    public delegate void GetGalleryCategoriesCompletedEventHandler(object sender, GetGalleryCategoriesCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGalleryCategoriesCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGalleryCategoriesCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GalleryCategoriesResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GalleryCategoriesResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    public delegate void GetGalleryApplicationDetailsCompletedEventHandler(object sender, GetGalleryApplicationDetailsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGalleryApplicationDetailsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGalleryApplicationDetailsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GalleryApplicationResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GalleryApplicationResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    public delegate void GetGalleryApplicationParamsCompletedEventHandler(object sender, GetGalleryApplicationParamsCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGalleryApplicationParamsCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGalleryApplicationParamsCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public DeploymentParametersResult Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((DeploymentParametersResult)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    public delegate void InstallCompletedEventHandler(object sender, InstallCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class InstallCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal InstallCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public StringResultObject Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((StringResultObject)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    public delegate void GetGalleryApplicationStatusCompletedEventHandler(object sender, GetGalleryApplicationStatusCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("wsdl", "2.0.50727.1432")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class GetGalleryApplicationStatusCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal GetGalleryApplicationStatusCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public GalleryWebAppStatus Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((GalleryWebAppStatus)(this.results[0]));
            }
        }
    }
}
