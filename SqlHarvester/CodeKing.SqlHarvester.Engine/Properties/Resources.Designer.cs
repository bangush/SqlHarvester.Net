﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.312
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CodeKing.SqlHarvester.Properties {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "2.0.0.0")]
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
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("CodeKing.SqlHarvester.Properties.Resources", typeof(Resources).Assembly);
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
        ///   Looks up a localized string similar to IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;SqlHarvesterSeeder&apos;) AND type in (N&apos;P&apos;, N&apos;PC&apos;))
        ///	DROP PROCEDURE dbo.SqlHarvesterSeeder
        ///GO
        ///
        ///CREATE PROCEDURE dbo.SqlHarvesterSeeder
        ///
        ///{parameters}
        ///
        ///AS
        ///
        ///	IF NOT EXISTS(SELECT * FROM {tablename} WHERE {whereclause})
        ///	BEGIN
        ///		INSERT INTO {tablename} ({columns})
        ///		VALUES ({values})
        ///	END
        ///
        ///
        ///GO
        ///.
        /// </summary>
        internal static string checked_insert {
            get {
                return ResourceManager.GetString("checked_insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Declare @Constraints Table(id int IDENTITY(1,1) NOT NULL,sql nvarchar(max))
        ///
        ///INSERT INTO @Constraints
        ///SELECT	&apos;ALTER TABLE [dbo].[&apos;+OBJECT_NAME(parent_object_id)+&apos;] {check} CONSTRAINT [&apos;+OBJECT_NAME(object_id)+&apos;]&apos; as Sql 
        ///FROM	sys.foreign_keys k 
        ///WHERE	referenced_object_id = OBJECT_ID(N&apos;{tablename}&apos;) or parent_object_id = OBJECT_ID(N&apos;{tablename}&apos;)
        ///
        ///Declare @Temp nvarchar(max),
        ///		@id int
        ///
        ///WHILE exists(SELECT * FROM @Constraints)
        ///BEGIN
        ///
        ///  SELECT	@temp = sql, @id=id
        ///  FROM		@Constraints d
        ///  ORDER [rest of string was truncated]&quot;;.
        /// </summary>
        internal static string constraints {
            get {
                return ResourceManager.GetString("constraints", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;SqlHarvesterSeeder&apos;) AND type in (N&apos;P&apos;, N&apos;PC&apos;))
        ///	DROP PROCEDURE dbo.SqlHarvesterSeeder
        ///GO
        ///.
        /// </summary>
        internal static string footer {
            get {
                return ResourceManager.GetString("footer", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET IDENTITY_INSERT {tablename} OFF.
        /// </summary>
        internal static string identity_off {
            get {
                return ResourceManager.GetString("identity_off", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET IDENTITY_INSERT {tablename} ON.
        /// </summary>
        internal static string identity_on {
            get {
                return ResourceManager.GetString("identity_on", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;SqlHarvesterSeeder&apos;) AND type in (N&apos;P&apos;, N&apos;PC&apos;))
        ///	DROP PROCEDURE dbo.SqlHarvesterSeeder
        ///GO
        ///
        ///CREATE PROCEDURE dbo.SqlHarvesterSeeder
        ///
        ///{parameters}
        ///
        ///AS
        ///
        ///	INSERT INTO {tablename} ({columns})
        ///	VALUES ({values})
        ///
        ///GO
        ///.
        /// </summary>
        internal static string insert {
            get {
                return ResourceManager.GetString("insert", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N&apos;SqlHarvesterSeeder&apos;) AND type in (N&apos;P&apos;, N&apos;PC&apos;))
        ///	DROP PROCEDURE dbo.SqlHarvesterSeeder
        ///GO
        ///
        ///CREATE PROCEDURE dbo.SqlHarvesterSeeder
        ///
        ///{parameters}
        ///
        ///AS
        ///
        ///	IF EXISTS(SELECT * FROM {tablename} WHERE {whereclause})
        ///	BEGIN
        ///		UPDATE 	 {tablename}
        ///		SET 	{setclause}
        ///		WHERE	{whereclause}
        ///	END
        ///	ELSE
        ///	BEGIN
        ///		INSERT INTO {tablename} ({columns})
        ///		VALUES ({values})
        ///	END
        ///
        ///
        ///GO
        ///.
        /// </summary>
        internal static string insert_update {
            get {
                return ResourceManager.GetString("insert_update", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Exec dbo.SqlHarvesterSeeder .
        /// </summary>
        internal static string item {
            get {
                return ResourceManager.GetString("item", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to SET NOCOUNT ON.
        /// </summary>
        internal static string on_count {
            get {
                return ResourceManager.GetString("on_count", resourceCulture);
            }
        }
    }
}
