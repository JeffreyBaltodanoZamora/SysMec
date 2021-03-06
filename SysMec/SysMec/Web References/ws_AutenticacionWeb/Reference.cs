﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace SysMec.ws_AutenticacionWeb {
    using System;
    using System.Web.Services;
    using System.Diagnostics;
    using System.Web.Services.Protocols;
    using System.Xml.Serialization;
    using System.ComponentModel;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="AutenticacionUsuariosMAGSoap", Namespace="http://sistemas.mag.go.cr/ws_Autenticacion")]
    public partial class AutenticacionUsuariosMAG : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback LoguerUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback LoguerUsuarioVB6OperationCompleted;
        
        private System.Threading.SendOrPostCallback verificarUsuarioOperationCompleted;
        
        private System.Threading.SendOrPostCallback verificarUsuarioSFEOperationCompleted;
        
        private System.Threading.SendOrPostCallback cambiarPasswordOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public AutenticacionUsuariosMAG() {
            this.Url = global::SysMec.Properties.Settings.Default.SysMec_ws_AutenticacionWeb_AutenticacionUsuariosMAG;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event LoguerUsuarioCompletedEventHandler LoguerUsuarioCompleted;
        
        /// <remarks/>
        public event LoguerUsuarioVB6CompletedEventHandler LoguerUsuarioVB6Completed;
        
        /// <remarks/>
        public event verificarUsuarioCompletedEventHandler verificarUsuarioCompleted;
        
        /// <remarks/>
        public event verificarUsuarioSFECompletedEventHandler verificarUsuarioSFECompleted;
        
        /// <remarks/>
        public event cambiarPasswordCompletedEventHandler cambiarPasswordCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sistemas.mag.go.cr/ws_Autenticacion/LoguerUsuario", RequestNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", ResponseNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] LoguerUsuario(string strNombreUsrEnc, string strPassUsrEnc, string PathSistema, bool boolConsiderarDominios) {
            object[] results = this.Invoke("LoguerUsuario", new object[] {
                        strNombreUsrEnc,
                        strPassUsrEnc,
                        PathSistema,
                        boolConsiderarDominios});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void LoguerUsuarioAsync(string strNombreUsrEnc, string strPassUsrEnc, string PathSistema, bool boolConsiderarDominios) {
            this.LoguerUsuarioAsync(strNombreUsrEnc, strPassUsrEnc, PathSistema, boolConsiderarDominios, null);
        }
        
        /// <remarks/>
        public void LoguerUsuarioAsync(string strNombreUsrEnc, string strPassUsrEnc, string PathSistema, bool boolConsiderarDominios, object userState) {
            if ((this.LoguerUsuarioOperationCompleted == null)) {
                this.LoguerUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoguerUsuarioOperationCompleted);
            }
            this.InvokeAsync("LoguerUsuario", new object[] {
                        strNombreUsrEnc,
                        strPassUsrEnc,
                        PathSistema,
                        boolConsiderarDominios}, this.LoguerUsuarioOperationCompleted, userState);
        }
        
        private void OnLoguerUsuarioOperationCompleted(object arg) {
            if ((this.LoguerUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoguerUsuarioCompleted(this, new LoguerUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sistemas.mag.go.cr/ws_Autenticacion/LoguerUsuarioVB6", RequestNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", ResponseNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string[] LoguerUsuarioVB6(string strNombreUsrEnc, string strPassUsrEnc, string PathSistema, bool boolConsiderarDominios) {
            object[] results = this.Invoke("LoguerUsuarioVB6", new object[] {
                        strNombreUsrEnc,
                        strPassUsrEnc,
                        PathSistema,
                        boolConsiderarDominios});
            return ((string[])(results[0]));
        }
        
        /// <remarks/>
        public void LoguerUsuarioVB6Async(string strNombreUsrEnc, string strPassUsrEnc, string PathSistema, bool boolConsiderarDominios) {
            this.LoguerUsuarioVB6Async(strNombreUsrEnc, strPassUsrEnc, PathSistema, boolConsiderarDominios, null);
        }
        
        /// <remarks/>
        public void LoguerUsuarioVB6Async(string strNombreUsrEnc, string strPassUsrEnc, string PathSistema, bool boolConsiderarDominios, object userState) {
            if ((this.LoguerUsuarioVB6OperationCompleted == null)) {
                this.LoguerUsuarioVB6OperationCompleted = new System.Threading.SendOrPostCallback(this.OnLoguerUsuarioVB6OperationCompleted);
            }
            this.InvokeAsync("LoguerUsuarioVB6", new object[] {
                        strNombreUsrEnc,
                        strPassUsrEnc,
                        PathSistema,
                        boolConsiderarDominios}, this.LoguerUsuarioVB6OperationCompleted, userState);
        }
        
        private void OnLoguerUsuarioVB6OperationCompleted(object arg) {
            if ((this.LoguerUsuarioVB6Completed != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.LoguerUsuarioVB6Completed(this, new LoguerUsuarioVB6CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sistemas.mag.go.cr/ws_Autenticacion/verificarUsuario", RequestNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", ResponseNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string verificarUsuario(string strUsuario) {
            object[] results = this.Invoke("verificarUsuario", new object[] {
                        strUsuario});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void verificarUsuarioAsync(string strUsuario) {
            this.verificarUsuarioAsync(strUsuario, null);
        }
        
        /// <remarks/>
        public void verificarUsuarioAsync(string strUsuario, object userState) {
            if ((this.verificarUsuarioOperationCompleted == null)) {
                this.verificarUsuarioOperationCompleted = new System.Threading.SendOrPostCallback(this.OnverificarUsuarioOperationCompleted);
            }
            this.InvokeAsync("verificarUsuario", new object[] {
                        strUsuario}, this.verificarUsuarioOperationCompleted, userState);
        }
        
        private void OnverificarUsuarioOperationCompleted(object arg) {
            if ((this.verificarUsuarioCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.verificarUsuarioCompleted(this, new verificarUsuarioCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sistemas.mag.go.cr/ws_Autenticacion/verificarUsuarioSFE", RequestNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", ResponseNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string verificarUsuarioSFE(string strUsuario, string strUsuarioAd, string strClaveAd) {
            object[] results = this.Invoke("verificarUsuarioSFE", new object[] {
                        strUsuario,
                        strUsuarioAd,
                        strClaveAd});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void verificarUsuarioSFEAsync(string strUsuario, string strUsuarioAd, string strClaveAd) {
            this.verificarUsuarioSFEAsync(strUsuario, strUsuarioAd, strClaveAd, null);
        }
        
        /// <remarks/>
        public void verificarUsuarioSFEAsync(string strUsuario, string strUsuarioAd, string strClaveAd, object userState) {
            if ((this.verificarUsuarioSFEOperationCompleted == null)) {
                this.verificarUsuarioSFEOperationCompleted = new System.Threading.SendOrPostCallback(this.OnverificarUsuarioSFEOperationCompleted);
            }
            this.InvokeAsync("verificarUsuarioSFE", new object[] {
                        strUsuario,
                        strUsuarioAd,
                        strClaveAd}, this.verificarUsuarioSFEOperationCompleted, userState);
        }
        
        private void OnverificarUsuarioSFEOperationCompleted(object arg) {
            if ((this.verificarUsuarioSFECompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.verificarUsuarioSFECompleted(this, new verificarUsuarioSFECompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://sistemas.mag.go.cr/ws_Autenticacion/cambiarPassword", RequestNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", ResponseNamespace="http://sistemas.mag.go.cr/ws_Autenticacion", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public string cambiarPassword(string strUsuario, string oldPassword, string newPassword) {
            object[] results = this.Invoke("cambiarPassword", new object[] {
                        strUsuario,
                        oldPassword,
                        newPassword});
            return ((string)(results[0]));
        }
        
        /// <remarks/>
        public void cambiarPasswordAsync(string strUsuario, string oldPassword, string newPassword) {
            this.cambiarPasswordAsync(strUsuario, oldPassword, newPassword, null);
        }
        
        /// <remarks/>
        public void cambiarPasswordAsync(string strUsuario, string oldPassword, string newPassword, object userState) {
            if ((this.cambiarPasswordOperationCompleted == null)) {
                this.cambiarPasswordOperationCompleted = new System.Threading.SendOrPostCallback(this.OncambiarPasswordOperationCompleted);
            }
            this.InvokeAsync("cambiarPassword", new object[] {
                        strUsuario,
                        oldPassword,
                        newPassword}, this.cambiarPasswordOperationCompleted, userState);
        }
        
        private void OncambiarPasswordOperationCompleted(object arg) {
            if ((this.cambiarPasswordCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.cambiarPasswordCompleted(this, new cambiarPasswordCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void LoguerUsuarioCompletedEventHandler(object sender, LoguerUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoguerUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoguerUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void LoguerUsuarioVB6CompletedEventHandler(object sender, LoguerUsuarioVB6CompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class LoguerUsuarioVB6CompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal LoguerUsuarioVB6CompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string[] Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string[])(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void verificarUsuarioCompletedEventHandler(object sender, verificarUsuarioCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class verificarUsuarioCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal verificarUsuarioCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void verificarUsuarioSFECompletedEventHandler(object sender, verificarUsuarioSFECompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class verificarUsuarioSFECompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal verificarUsuarioSFECompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    public delegate void cambiarPasswordCompletedEventHandler(object sender, cambiarPasswordCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.6.1586.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    public partial class cambiarPasswordCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        internal cambiarPasswordCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        /// <remarks/>
        public string Result {
            get {
                this.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
}

#pragma warning restore 1591