﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using DslModeling = global::Microsoft.VisualStudio.Modeling;
using DslDesign = global::Microsoft.VisualStudio.Modeling.Design;
using DslDiagrams = global::Microsoft.VisualStudio.Modeling.Diagrams;

namespace UPM_IPS.MDFSJPGVSProyectoIPS
{
	/// <summary>
	/// DomainClass MetaforaAsociacion
	/// Description for UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaAsociacion
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaAsociacion.DisplayName", typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel), "UPM_IPS.MDFSJPGVSProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaAsociacion.Description", typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel), "UPM_IPS.MDFSJPGVSProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("35d1207a-8e09-4475-a62e-70a7fe25e2f2")]
	public partial class MetaforaAsociacion : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with MetaforaAsociacion.
		/// </summary>
		public static DslDiagrams::Decorator FindMetaforaAsociacionDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		
		/// <summary>
		/// Shape instance initialization.
		/// </summary>
		public override void OnInitialize()
		{
			base.OnInitialize();
			
			// Create host shapes for outer decorators.
			foreach(DslDiagrams::Decorator decorator in this.Decorators)
			{
				if(decorator.RequiresHost)
				{
					decorator.ConfigureHostShape(this);
				}
			}
			
		}
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes style set resources for this shape type
		/// </summary>
		/// <param name="classStyleSet">The style set for this shape class</param>
		protected override void InitializeResources(DslDiagrams::StyleSet classStyleSet)
		{
			base.InitializeResources(classStyleSet);
			
			// Line pen settings for this connector.
			DslDiagrams::PenSettings linePen = new DslDiagrams::PenSettings();
			linePen.Width = 0.025f;
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLine, linePen);
			// Custom font styles
			DslDiagrams::FontSettings fontSettings;
			fontSettings = new DslDiagrams::FontSettings();
			fontSettings.Style =  global::System.Drawing.FontStyle.Bold ;
			fontSettings.Size = 8/72.0F;
			classStyleSet.AddFont(new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8"), DslDiagrams::DiagramFonts.ShapeText, fontSettings);
		}
		
		#endregion
		
		#region Decorators
		/// <summary>
		/// Initialize the collection of shape fields associated with this shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
		}
		
		/// <summary>
		/// Initialize the collection of decorators associated with this shape type.  This method also
		/// creates shape fields for outer decorators, because these are not part of the shape fields collection
		/// associated with the shape, so they must be created here rather than in InitializeShapeFields.
		/// </summary>
		protected override void InitializeDecorators(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields, global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators)
		{
			base.InitializeDecorators(shapeFields, decorators);
			
			DslDiagrams::TextField field1 = new DslDiagrams::TextField("NombreAsociacion");
			field1.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaAsociacionNombreAsociacionDefaultText");
			field1.DefaultFocusable = true;
			field1.DefaultAutoSize = true;
			field1.AnchoringBehavior.MinimumHeightInLines = 1;
			field1.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field1.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			field1.DefaultFontId = new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8");			
			DslDiagrams::Decorator decorator1 = new DslDiagrams::ConnectorDecorator(field1, DslDiagrams::ConnectorDecoratorPosition.SourceTop, DslDiagrams::PointD.Empty, true);
			decorators.Add(decorator1);
				
			DslDiagrams::TextField field2 = new DslDiagrams::TextField("CardinalidadInit");
			field2.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaAsociacionCardinalidadInitDefaultText");
			field2.DefaultFocusable = true;
			field2.DefaultAutoSize = true;
			field2.AnchoringBehavior.MinimumHeightInLines = 1;
			field2.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field2.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			field2.DefaultFontId = new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8");			
			DslDiagrams::Decorator decorator2 = new DslDiagrams::ConnectorDecorator(field2, DslDiagrams::ConnectorDecoratorPosition.SourceBottom, DslDiagrams::PointD.Empty, true);
			decorators.Add(decorator2);
				
			DslDiagrams::TextField field3 = new DslDiagrams::TextField("CardinalidadFin");
			field3.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaAsociacionCardinalidadFinDefaultText");
			field3.DefaultFocusable = true;
			field3.DefaultAutoSize = true;
			field3.AnchoringBehavior.MinimumHeightInLines = 1;
			field3.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field3.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			field3.DefaultFontId = new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8");			
			DslDiagrams::Decorator decorator3 = new DslDiagrams::ConnectorDecorator(field3, DslDiagrams::ConnectorDecoratorPosition.TargetBottom, DslDiagrams::PointD.Empty, true);
			decorators.Add(decorator3);
				
		}
		
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// MetaforaAsociacion domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x35d1207a, 0x8e09, 0x4475, 0xa6, 0x2e, 0x70, 0xa7, 0xfe, 0x25, 0xe2, 0xf2);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MetaforaAsociacion(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MetaforaAsociacion(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace UPM_IPS.MDFSJPGVSProyectoIPS
{
	/// <summary>
	/// DomainClass MetaforaAgregacionFuerte
	/// Description for UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaAgregacionFuerte
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaAgregacionFuerte.DisplayName", typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel), "UPM_IPS.MDFSJPGVSProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaAgregacionFuerte.Description", typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel), "UPM_IPS.MDFSJPGVSProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("eaf061b3-9acf-4f59-957b-018125cb05d9")]
	public partial class MetaforaAgregacionFuerte : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with MetaforaAgregacionFuerte.
		/// </summary>
		public static DslDiagrams::Decorator FindMetaforaAgregacionFuerteDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		
		/// <summary>
		/// Shape instance initialization.
		/// </summary>
		public override void OnInitialize()
		{
			base.OnInitialize();
			
			// Create host shapes for outer decorators.
			foreach(DslDiagrams::Decorator decorator in this.Decorators)
			{
				if(decorator.RequiresHost)
				{
					decorator.ConfigureHostShape(this);
				}
			}
			
		}
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes style set resources for this shape type
		/// </summary>
		/// <param name="classStyleSet">The style set for this shape class</param>
		protected override void InitializeResources(DslDiagrams::StyleSet classStyleSet)
		{
			base.InitializeResources(classStyleSet);
			
			// Line pen settings for this connector.
			DslDiagrams::PenSettings linePen = new DslDiagrams::PenSettings();
			linePen.Color = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.DarkRed);
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLineDecorator, linePen);
			linePen.Width = 0.025f;
			linePen.DashStyle = global::System.Drawing.Drawing2D.DashStyle.Dash;
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLine, linePen);
			DslDiagrams::BrushSettings lineBrush = new DslDiagrams::BrushSettings();
			lineBrush.Color = global::System.Drawing.Color.FromKnownColor(global::System.Drawing.KnownColor.DarkRed);
			classStyleSet.OverrideBrush(DslDiagrams::DiagramBrushes.ConnectionLineDecorator, lineBrush);
			
			// Custom font styles
			DslDiagrams::FontSettings fontSettings;
			fontSettings = new DslDiagrams::FontSettings();
			fontSettings.Style =  global::System.Drawing.FontStyle.Bold ;
			fontSettings.Size = 8/72.0F;
			classStyleSet.AddFont(new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8"), DslDiagrams::DiagramFonts.ShapeText, fontSettings);
		}
		
		/// <summary>
		/// Initializes resources associated with this connector instance.
		/// </summary>
		protected override void InitializeInstanceResources()
		{
			base.InitializeInstanceResources();
			this.SetDecorators(null, new DslDiagrams::SizeD(0.1,0.1), DslDiagrams::LinkDecorator.DecoratorFilledDiamond, new DslDiagrams::SizeD(0.1,0.2), false);
		}
		
		#endregion
		
		#region Decorators
		/// <summary>
		/// Initialize the collection of shape fields associated with this shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
		}
		
		/// <summary>
		/// Initialize the collection of decorators associated with this shape type.  This method also
		/// creates shape fields for outer decorators, because these are not part of the shape fields collection
		/// associated with the shape, so they must be created here rather than in InitializeShapeFields.
		/// </summary>
		protected override void InitializeDecorators(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields, global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators)
		{
			base.InitializeDecorators(shapeFields, decorators);
			
			DslDiagrams::TextField field1 = new DslDiagrams::TextField("NombreAgregacionFuerte");
			field1.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaAgregacionFuerteNombreAgregacionFuerteDefaultText");
			field1.DefaultFocusable = true;
			field1.DefaultAutoSize = true;
			field1.AnchoringBehavior.MinimumHeightInLines = 1;
			field1.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field1.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			field1.DefaultFontId = new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8");			
			DslDiagrams::Decorator decorator1 = new DslDiagrams::ConnectorDecorator(field1, DslDiagrams::ConnectorDecoratorPosition.SourceTop, DslDiagrams::PointD.Empty, true);
			decorators.Add(decorator1);
				
			DslDiagrams::TextField field2 = new DslDiagrams::TextField("CardinalidadAgregacionFuerteInit");
			field2.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaAgregacionFuerteCardinalidadAgregacionFuerteInitDefaultText");
			field2.DefaultFocusable = true;
			field2.DefaultAutoSize = true;
			field2.AnchoringBehavior.MinimumHeightInLines = 1;
			field2.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field2.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			field2.DefaultFontId = new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8");			
			DslDiagrams::Decorator decorator2 = new DslDiagrams::ConnectorDecorator(field2, DslDiagrams::ConnectorDecoratorPosition.SourceBottom, DslDiagrams::PointD.Empty, true);
			decorators.Add(decorator2);
				
			DslDiagrams::TextField field3 = new DslDiagrams::TextField("CardinalidadAgregacionFuerteFin");
			field3.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaAgregacionFuerteCardinalidadAgregacionFuerteFinDefaultText");
			field3.DefaultFocusable = true;
			field3.DefaultAutoSize = true;
			field3.AnchoringBehavior.MinimumHeightInLines = 1;
			field3.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field3.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			field3.DefaultFontId = new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8");			
			DslDiagrams::Decorator decorator3 = new DslDiagrams::ConnectorDecorator(field3, DslDiagrams::ConnectorDecoratorPosition.TargetBottom, DslDiagrams::PointD.Empty, true);
			decorators.Add(decorator3);
				
		}
		
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// MetaforaAgregacionFuerte domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xeaf061b3, 0x9acf, 0x4f59, 0x95, 0x7b, 0x01, 0x81, 0x25, 0xcb, 0x05, 0xd9);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MetaforaAgregacionFuerte(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MetaforaAgregacionFuerte(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace UPM_IPS.MDFSJPGVSProyectoIPS
{
	/// <summary>
	/// DomainClass MetaforaAgregacionDebil
	/// Description for UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaAgregacionDebil
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaAgregacionDebil.DisplayName", typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel), "UPM_IPS.MDFSJPGVSProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaAgregacionDebil.Description", typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel), "UPM_IPS.MDFSJPGVSProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("cf444ed4-c950-49bc-ad43-9d5529a24eb1")]
	public partial class MetaforaAgregacionDebil : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with MetaforaAgregacionDebil.
		/// </summary>
		public static DslDiagrams::Decorator FindMetaforaAgregacionDebilDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		
		/// <summary>
		/// Shape instance initialization.
		/// </summary>
		public override void OnInitialize()
		{
			base.OnInitialize();
			
			// Create host shapes for outer decorators.
			foreach(DslDiagrams::Decorator decorator in this.Decorators)
			{
				if(decorator.RequiresHost)
				{
					decorator.ConfigureHostShape(this);
				}
			}
			
		}
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes style set resources for this shape type
		/// </summary>
		/// <param name="classStyleSet">The style set for this shape class</param>
		protected override void InitializeResources(DslDiagrams::StyleSet classStyleSet)
		{
			base.InitializeResources(classStyleSet);
			
			// Line pen settings for this connector.
			DslDiagrams::PenSettings linePen = new DslDiagrams::PenSettings();
			linePen.Width = 0.025f;
			linePen.DashStyle = global::System.Drawing.Drawing2D.DashStyle.Dash;
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLine, linePen);
			// Custom font styles
			DslDiagrams::FontSettings fontSettings;
			fontSettings = new DslDiagrams::FontSettings();
			fontSettings.Style =  global::System.Drawing.FontStyle.Bold ;
			fontSettings.Size = 8/72.0F;
			classStyleSet.AddFont(new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8"), DslDiagrams::DiagramFonts.ShapeText, fontSettings);
		}
		
		/// <summary>
		/// Initializes resources associated with this connector instance.
		/// </summary>
		protected override void InitializeInstanceResources()
		{
			base.InitializeInstanceResources();
			this.SetDecorators(null, new DslDiagrams::SizeD(0.1,0.1), DslDiagrams::LinkDecorator.DecoratorEmptyDiamond, new DslDiagrams::SizeD(0.1,0.3), false);
		}
		
		#endregion
		
		#region Decorators
		/// <summary>
		/// Initialize the collection of shape fields associated with this shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
		}
		
		/// <summary>
		/// Initialize the collection of decorators associated with this shape type.  This method also
		/// creates shape fields for outer decorators, because these are not part of the shape fields collection
		/// associated with the shape, so they must be created here rather than in InitializeShapeFields.
		/// </summary>
		protected override void InitializeDecorators(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields, global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators)
		{
			base.InitializeDecorators(shapeFields, decorators);
			
			DslDiagrams::TextField field1 = new DslDiagrams::TextField("NombreAgregacionDebil");
			field1.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaAgregacionDebilNombreAgregacionDebilDefaultText");
			field1.DefaultFocusable = true;
			field1.DefaultAutoSize = true;
			field1.AnchoringBehavior.MinimumHeightInLines = 1;
			field1.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field1.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			DslDiagrams::Decorator decorator1 = new DslDiagrams::ConnectorDecorator(field1, DslDiagrams::ConnectorDecoratorPosition.SourceTop, DslDiagrams::PointD.Empty, true);
			decorators.Add(decorator1);
				
			DslDiagrams::TextField field2 = new DslDiagrams::TextField("CardinalidadAgregacionDebilFin");
			field2.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaAgregacionDebilCardinalidadAgregacionDebilFinDefaultText");
			field2.DefaultFocusable = true;
			field2.DefaultAutoSize = true;
			field2.AnchoringBehavior.MinimumHeightInLines = 1;
			field2.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field2.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			DslDiagrams::Decorator decorator2 = new DslDiagrams::ConnectorDecorator(field2, DslDiagrams::ConnectorDecoratorPosition.TargetBottom, DslDiagrams::PointD.Empty, true);
			decorators.Add(decorator2);
				
			DslDiagrams::TextField field3 = new DslDiagrams::TextField("CardinalidadAgregacionDebilInit");
			field3.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaAgregacionDebilCardinalidadAgregacionDebilInitDefaultText");
			field3.DefaultFocusable = true;
			field3.DefaultAutoSize = true;
			field3.AnchoringBehavior.MinimumHeightInLines = 1;
			field3.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field3.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			field3.DefaultFontId = new DslDiagrams::StyleSetResourceId(string.Empty, "ShapeTextBold8");			
			DslDiagrams::Decorator decorator3 = new DslDiagrams::ConnectorDecorator(field3, DslDiagrams::ConnectorDecoratorPosition.SourceBottom, DslDiagrams::PointD.Empty, true);
			decorators.Add(decorator3);
				
		}
		
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// MetaforaAgregacionDebil domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0xcf444ed4, 0xc950, 0x49bc, 0xad, 0x43, 0x9d, 0x55, 0x29, 0xa2, 0x4e, 0xb1);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MetaforaAgregacionDebil(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MetaforaAgregacionDebil(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
namespace UPM_IPS.MDFSJPGVSProyectoIPS
{
	/// <summary>
	/// DomainClass MetaforaHerencia
	/// Description for UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaHerencia
	/// </summary>
	[DslDesign::DisplayNameResource("UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaHerencia.DisplayName", typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel), "UPM_IPS.MDFSJPGVSProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslDesign::DescriptionResource("UPM_IPS.MDFSJPGVSProyectoIPS.MetaforaHerencia.Description", typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel), "UPM_IPS.MDFSJPGVSProyectoIPS.GeneratedCode.DomainModelResx")]
	[DslModeling::DomainModelOwner(typeof(global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel))]
	[global::System.CLSCompliant(true)]
	[DslModeling::DomainObjectId("36d6b470-f30b-48b7-8e3a-63a40ef648cc")]
	public partial class MetaforaHerencia : DslDiagrams::BinaryLinkShape
	{
		#region DiagramElement boilerplate
		private static DslDiagrams::StyleSet classStyleSet;
		private static global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields;
		private static global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators;
		
		/// <summary>
		/// Per-class style set for this shape.
		/// </summary>
		protected override DslDiagrams::StyleSet ClassStyleSet
		{
			get
			{
				if (classStyleSet == null)
				{
					classStyleSet = CreateClassStyleSet();
				}
				return classStyleSet;
			}
		}
		
		/// <summary>
		/// Per-class ShapeFields for this shape.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::ShapeField> ShapeFields
		{
			get
			{
				if (shapeFields == null)
				{
					shapeFields = CreateShapeFields();
				}
				return shapeFields;
			}
		}
		
		/// <summary>
		/// Event fired when decorator initialization is complete for this shape type.
		/// </summary>
		public static event global::System.EventHandler DecoratorsInitialized;
		
		/// <summary>
		/// List containing decorators used by this type.
		/// </summary>
		public override global::System.Collections.Generic.IList<DslDiagrams::Decorator> Decorators
		{
			get 
			{
				if(decorators == null)
				{
					decorators = CreateDecorators();
					
					// fire this event to allow the diagram to initialize decorator mappings for this shape type.
					if(DecoratorsInitialized != null)
					{
						DecoratorsInitialized(this, global::System.EventArgs.Empty);
					}
				}
				
				return decorators; 
			}
		}
		
		/// <summary>
		/// Finds a decorator associated with MetaforaHerencia.
		/// </summary>
		public static DslDiagrams::Decorator FindMetaforaHerenciaDecorator(string decoratorName)
		{	
			if(decorators == null) return null;
			return DslDiagrams::ShapeElement.FindDecorator(decorators, decoratorName);
		}
		
		
		/// <summary>
		/// Shape instance initialization.
		/// </summary>
		public override void OnInitialize()
		{
			base.OnInitialize();
			
			// Create host shapes for outer decorators.
			foreach(DslDiagrams::Decorator decorator in this.Decorators)
			{
				if(decorator.RequiresHost)
				{
					decorator.ConfigureHostShape(this);
				}
			}
			
		}
		#endregion
		
		#region Connector styles
		/// <summary>
		/// Initializes style set resources for this shape type
		/// </summary>
		/// <param name="classStyleSet">The style set for this shape class</param>
		protected override void InitializeResources(DslDiagrams::StyleSet classStyleSet)
		{
			base.InitializeResources(classStyleSet);
			
			// Line pen settings for this connector.
			DslDiagrams::PenSettings linePen = new DslDiagrams::PenSettings();
			linePen.Width = 0.025f;
			classStyleSet.OverridePen(DslDiagrams::DiagramPens.ConnectionLine, linePen);
		}
		
		/// <summary>
		/// Initializes resources associated with this connector instance.
		/// </summary>
		protected override void InitializeInstanceResources()
		{
			base.InitializeInstanceResources();
			this.SetDecorators(null, new DslDiagrams::SizeD(0.1,0.1), DslDiagrams::LinkDecorator.DecoratorHollowArrow, new DslDiagrams::SizeD(0.1,0.3), false);
		}
		
		#endregion
		
		#region Decorators
		/// <summary>
		/// Initialize the collection of shape fields associated with this shape type.
		/// </summary>
		protected override void InitializeShapeFields(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields)
		{
			base.InitializeShapeFields(shapeFields);
		}
		
		/// <summary>
		/// Initialize the collection of decorators associated with this shape type.  This method also
		/// creates shape fields for outer decorators, because these are not part of the shape fields collection
		/// associated with the shape, so they must be created here rather than in InitializeShapeFields.
		/// </summary>
		protected override void InitializeDecorators(global::System.Collections.Generic.IList<DslDiagrams::ShapeField> shapeFields, global::System.Collections.Generic.IList<DslDiagrams::Decorator> decorators)
		{
			base.InitializeDecorators(shapeFields, decorators);
			
			DslDiagrams::TextField field1 = new DslDiagrams::TextField("Total/Parcia");
			field1.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaHerenciaTotal/ParciaDefaultText");
			field1.DefaultFocusable = true;
			field1.DefaultAutoSize = true;
			field1.AnchoringBehavior.MinimumHeightInLines = 1;
			field1.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field1.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			DslDiagrams::Decorator decorator1 = new DslDiagrams::ConnectorDecorator(field1, DslDiagrams::ConnectorDecoratorPosition.TargetTop, DslDiagrams::PointD.Empty);
			decorators.Add(decorator1);
				
			DslDiagrams::TextField field2 = new DslDiagrams::TextField("Solapada/Disjunta");
			field2.DefaultText = global::UPM_IPS.MDFSJPGVSProyectoIPS.MDFSJPGVSProyectoIPSDomainModel.SingletonResourceManager.GetString("MetaforaHerenciaSolapada/DisjuntaDefaultText");
			field2.DefaultFocusable = true;
			field2.DefaultAutoSize = true;
			field2.AnchoringBehavior.MinimumHeightInLines = 1;
			field2.AnchoringBehavior.MinimumWidthInCharacters = 1;
			field2.DefaultAccessibleState = global::System.Windows.Forms.AccessibleStates.Invisible;
			DslDiagrams::Decorator decorator2 = new DslDiagrams::ConnectorDecorator(field2, DslDiagrams::ConnectorDecoratorPosition.TargetBottom, DslDiagrams::PointD.Empty);
			decorators.Add(decorator2);
				
		}
		
		#endregion
		
		#region Constructors, domain class Id
	
		/// <summary>
		/// MetaforaHerencia domain class Id.
		/// </summary>
		public static readonly new global::System.Guid DomainClassId = new global::System.Guid(0x36d6b470, 0xf30b, 0x48b7, 0x8e, 0x3a, 0x63, 0xa4, 0x0e, 0xf6, 0x48, 0xcc);
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="store">Store where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MetaforaHerencia(DslModeling::Store store, params DslModeling::PropertyAssignment[] propertyAssignments)
			: this(store != null ? store.DefaultPartitionForClass(DomainClassId) : null, propertyAssignments)
		{
		}
		
		/// <summary>
		/// Constructor
		/// </summary>
		/// <param name="partition">Partition where new element is to be created.</param>
		/// <param name="propertyAssignments">List of domain property id/value pairs to set once the element is created.</param>
		public MetaforaHerencia(DslModeling::Partition partition, params DslModeling::PropertyAssignment[] propertyAssignments)
			: base(partition, propertyAssignments)
		{
		}
		#endregion
	}
}
