﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebPageTemplateGenerator {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("WebPageTemplateGenerator.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to ECHO OFF
        ///for %%i in (*.jade) do start jade -P -o .. %%~nxi.
        /// </summary>
        internal static string buildjade_bat {
            get {
                return ResourceManager.GetString("buildjade_bat", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to meta(http-equiv=&quot;Content-Type&quot;, content=&quot;text/html; charset=UTF-8&quot;)
        ///meta(name=&quot;author&quot;, content=&quot;Ryan Bucinell&quot;)
        ///meta(name=&quot;viewport&quot;, content=&quot;width=device-width, initial-scale=1, maximum-scale=1&quot;)
        ///meta(name=&quot;description&quot;, content=&quot;Course content for #{pageName}&quot;)
        ///meta(name=&quot;keywords&quot;, content=&quot;factulty profile, ronlad bucinell, union college, mechanical engineering, #{pageName}&quot;)
        ///
        ///link( rel=&quot;shortcut icon&quot;, href=&quot;/img/favicon.ico&quot;)
        ///
        ///link( rel=&quot;stylesheet&quot;, href=&quot;/css/bootstrap.css&quot;)
        ///link( rel=&quot;st [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string course_head {
            get {
                return ResourceManager.GetString("course_head", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to script( type=&quot;text/javascript&quot;, src=&quot;/js/nav.js&quot;)
        ///#sidebar
        ///    a.mobilemenu(href=&quot;#sidebar&quot;): i.fa.fa-bars
        ///    #main-nav
        ///        #nav-container
        ///            #profile.clearfix
        ///                .portrate.hidden-xs
        ///                .title
        ///                    h2 Ronald B. Bucinell, Ph.D., P.E.
        ///                    h3 Union College
        ///            nav
        ///                ul#navigation
        ///                    script.
        ///                        $(function() {
        ///                            displayResult( &quot;content/nav.xml&quot; [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string course_nav {
            get {
                return ResourceManager.GetString("course_nav", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;!DOCTYPE html&gt;
        ///&lt;!-- Do not modify this file! It was automatically generated. To change it&apos;s content go to content folder--&gt;
        ///&lt;html&gt;
        ///    &lt;head&gt;
        ///      &lt;meta http-equiv=&quot;Content-Type&quot; content=&quot;text/html; charset=UTF-8&quot;&gt;
        ///      &lt;meta name=&quot;author&quot; content=&quot;Ryan Bucinell&quot;&gt;
        ///      &lt;meta name=&quot;viewport&quot; content=&quot;width=device-width, initial-scale=1, maximum-scale=1&quot;&gt;
        ///      &lt;meta name=&quot;description&quot; content=&quot;Course content for Schedule&quot;&gt;
        ///      &lt;meta name=&quot;keywords&quot; content=&quot;factulty profile, ronlad bucinell, un [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string GeneratedHTMLTemplate {
            get {
                return ResourceManager.GetString("GeneratedHTMLTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to doctype
        ///// Do not modify this file! It was automatically generated. To change it&apos;s content go to content folder
        ///html
        ///	include ./support/pagegeneration.jade
        ///	+createCourseTemplate(&quot;{0}&quot;, &quot;{1}&quot;, &quot;content/{2}&quot;).
        /// </summary>
        internal static string JadeTemplate {
            get {
                return ResourceManager.GetString("JadeTemplate", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;xsl:stylesheet version=&quot;1.0&quot; xmlns:xsl=&quot;http://www.w3.org/1999/XSL/Transform&quot;&gt;
        ///  &lt;xsl:template match=&quot;/&quot;&gt;
        ///  
        ///	&lt;xsl:for-each select=&quot;navigation/item&quot;&gt;
        ///		
        ///		&lt;xsl:element name=&quot;li&quot;&gt;
        ///			&lt;xsl:attribute name=&quot;class&quot;&gt;navitem&lt;/xsl:attribute&gt;
        ///			
        ///			&lt;xsl:element name=&quot;a&quot;&gt;
        ///				&lt;xsl:attribute name=&quot;href&quot;&gt;#&lt;/xsl:attribute&gt;
        ///				
        ///				&lt;xsl:element name=&quot;div&quot;&gt;
        ///					&lt;xsl:attribute name=&quot;class&quot;&gt;text&lt;/xsl:attribute&gt;					
        ///					&lt;xsl:value-of select=&quot;@name&quot; /&gt;
        ///				&lt;/xsl:element&gt;&lt;!--end the div showing menu category--&gt;				
        ///			&lt;/ [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string nav_transform {
            get {
                return ResourceManager.GetString("nav_transform", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to //- Create Page Header
        ///mixin createCourseTemplate(menu, pageName, contenturl)
        ///	head
        ///		include ./course_head.jade
        ///	body
        ///		article#wrapper
        ///			//- side navigation menu
        ///			include ./course_nav.jade
        ///			
        ///			//- main content
        ///			main.container#main
        ///				header.page-header
        ///					h1#pageheader #{pageName}
        ///					ul.breadcrumb
        ///						li #{menu}
        ///						li.active: a(href=&quot;#&quot;) #{pageName}
        ///				section#dadcontent    
        ///					script. 
        ///						$( &quot;#dadcontent&quot; ).load( &quot;#{contenturl}&quot; );
        ///					
        ///			//- footer
        ///			foote [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string pagegeneration {
            get {
                return ResourceManager.GetString("pagegeneration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;?xml version=&quot;1.0&quot; encoding=&quot;UTF-8&quot;?&gt;
        ///&lt;?xml-stylesheet type=&quot;text/xsl&quot; href=&quot;nav_transform.xsl&quot;?&gt;
        ///&lt;navigation&gt;
        ///
        ///&lt;/navigation&gt;.
        /// </summary>
        internal static string XMLDoc {
            get {
                return ResourceManager.GetString("XMLDoc", resourceCulture);
            }
        }
    }
}
