﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Lands.Resources {
    using System;
    using System.Reflection;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Resource {
        
        private static System.Resources.ResourceManager resourceMan;
        
        private static System.Globalization.CultureInfo resourceCulture;
        
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resource() {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Resources.ResourceManager ResourceManager {
            get {
                if (object.Equals(null, resourceMan)) {
                    System.Resources.ResourceManager temp = new System.Resources.ResourceManager("Lands.Resources.Resource", typeof(Resource).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        public static System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        public static string Accept {
            get {
                return ResourceManager.GetString("Accept", resourceCulture);
            }
        }
        
        public static string EmailPlaceHolder {
            get {
                return ResourceManager.GetString("EmailPlaceHolder", resourceCulture);
            }
        }
        
        public static string EmailValidation {
            get {
                return ResourceManager.GetString("EmailValidation", resourceCulture);
            }
        }
        
        public static string Error {
            get {
                return ResourceManager.GetString("Error", resourceCulture);
            }
        }
        
        public static string PasswordValidation {
            get {
                return ResourceManager.GetString("PasswordValidation", resourceCulture);
            }
        }
        
        public static string Rememberme {
            get {
                return ResourceManager.GetString("Rememberme", resourceCulture);
            }
        }
        
        public static string SomethingWrong {
            get {
                return ResourceManager.GetString("SomethingWrong", resourceCulture);
            }
        }
        
        public static string Login {
            get {
                return ResourceManager.GetString("Login", resourceCulture);
            }
        }
        
        public static string EMail {
            get {
                return ResourceManager.GetString("EMail", resourceCulture);
            }
        }
        
        public static string Password {
            get {
                return ResourceManager.GetString("Password", resourceCulture);
            }
        }
        
        public static string PasswordPlaceHolder {
            get {
                return ResourceManager.GetString("PasswordPlaceHolder", resourceCulture);
            }
        }
        
        public static string Forgot {
            get {
                return ResourceManager.GetString("Forgot", resourceCulture);
            }
        }
        
        public static string Register {
            get {
                return ResourceManager.GetString("Register", resourceCulture);
            }
        }
    }
}
