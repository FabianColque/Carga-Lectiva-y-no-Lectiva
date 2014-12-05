/*
               File: DPDolphinMenuData
        Description: DPDolphin Menu Data
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 12/3/2014 8:59:15.96
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class dpdolphinmenudata : GXProcedure
   {
      public dpdolphinmenudata( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Modern");
      }

      public dpdolphinmenudata( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( out IGxCollection aP0_Gxm2rootcol )
      {
         this.Gxm2rootcol = new GxObjectCollection( context, "MenuData.MenuDataItem", "Carga", "SdtMenuData_MenuDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      public IGxCollection executeUdp( )
      {
         this.Gxm2rootcol = new GxObjectCollection( context, "MenuData.MenuDataItem", "Carga", "SdtMenuData_MenuDataItem", "GeneXus.Programs") ;
         initialize();
         executePrivate();
         aP0_Gxm2rootcol=this.Gxm2rootcol;
         return Gxm2rootcol ;
      }

      public void executeSubmit( out IGxCollection aP0_Gxm2rootcol )
      {
         dpdolphinmenudata objdpdolphinmenudata;
         objdpdolphinmenudata = new dpdolphinmenudata();
         objdpdolphinmenudata.Gxm2rootcol = new GxObjectCollection( context, "MenuData.MenuDataItem", "Carga", "SdtMenuData_MenuDataItem", "GeneXus.Programs") ;
         objdpdolphinmenudata.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objdpdolphinmenudata.executePrivateCatch ));
         aP0_Gxm2rootcol=this.Gxm2rootcol;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         Gxm1menudata = new SdtMenuData_MenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1menudata, 0);
         Gxm1menudata.gxTpr_Menuid = 1 ;
         Gxm1menudata.gxTpr_Menutitle = "INICIO" ;
         Gxm1menudata.gxTpr_Menudescription = "INICIO - VISTA PRINCIPAL" ;
         Gxm1menudata.gxTpr_Menuurl = "main.aspx" ;
         Gxm1menudata = new SdtMenuData_MenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1menudata, 0);
         Gxm1menudata.gxTpr_Menuid = 2 ;
         Gxm1menudata.gxTpr_Menutitle = "CATEGORIA" ;
         Gxm1menudata.gxTpr_Menudescription = "CATEGORIA DEL DOCENTE " ;
         Gxm1menudata.gxTpr_Menuurl = "categoria.aspx" ;
         Gxm1menudata = new SdtMenuData_MenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1menudata, 0);
         Gxm1menudata.gxTpr_Menuid = 3 ;
         Gxm1menudata.gxTpr_Menutitle = "ESCUELA" ;
         Gxm1menudata.gxTpr_Menudescription = "ESCUELA PROFESIONAL DE LA UNSA" ;
         Gxm1menudata.gxTpr_Menuurl = "escuela.aspx" ;
         Gxm1menudata = new SdtMenuData_MenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1menudata, 0);
         Gxm1menudata.gxTpr_Menuid = 4 ;
         Gxm1menudata.gxTpr_Menutitle = "ASIGNATURA" ;
         Gxm1menudata.gxTpr_Menudescription = "ASIGNATURA DICTADA" ;
         Gxm1menudata.gxTpr_Menuurl = "asignatura.aspx" ;
         Gxm1menudata = new SdtMenuData_MenuDataItem(context) ;
         Gxm2rootcol.Add(Gxm1menudata, 0);
         Gxm1menudata.gxTpr_Menuid = 5 ;
         Gxm1menudata.gxTpr_Menutitle = "DOCENTE" ;
         Gxm1menudata.gxTpr_Menudescription = "CONFIGURACION DE LOS DOCENTES" ;
         Gxm1menudata.gxTpr_Menuurl = "docente.aspx" ;
         this.cleanup();
      }

      protected void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         Gxm1menudata = new SdtMenuData_MenuDataItem(context);
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private IGxCollection aP0_Gxm2rootcol ;
      [ObjectCollection(ItemType=typeof( SdtMenuData_MenuDataItem ))]
      private IGxCollection Gxm2rootcol ;
      private SdtMenuData_MenuDataItem Gxm1menudata ;
   }

}
