/*
               File: CargaLectiva
        Description: Carga Lectiva
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 12/3/2014 8:48:35.24
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class cargalectiva : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      protected void INITENV( )
      {
         if ( GxWebError != 0 )
         {
            return  ;
         }
      }

      protected void INITTRN( )
      {
         initialize_properties( ) ;
         entryPointCalled = false ;
         gxfirstwebparm = GetNextPar( ) ;
         gxfirstwebparm_bkp = gxfirstwebparm ;
         gxfirstwebparm = DecryptAjaxCall( gxfirstwebparm, "High") ;
         if ( StringUtil.StrCmp(gxfirstwebparm, "dyncall") == 0 )
         {
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            dyncall( GetNextPar( )) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_5") == 0 )
         {
            A4DocenteId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_5( A4DocenteId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_6") == 0 )
         {
            A22AsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_6( A22AsignaturaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxExecAct_"+"gxLoad_7") == 0 )
         {
            A11EscuelaId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EscuelaId), 4, 0)));
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxLoad_7( A11EscuelaId) ;
            return  ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxEvt") == 0 )
         {
            setAjaxEventMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = GetNextPar( ) ;
         }
         else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Gridcargalectiva_detalle") == 0 )
         {
            nRC_Gridcargalectiva_detalle = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            nGXsfl_50_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
            sGXsfl_50_idx = GetNextPar( ) ;
            setAjaxCallMode();
            if ( ! IsValidAjaxCall( true) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxnrGridcargalectiva_detalle_newrow( nRC_Gridcargalectiva_detalle, nGXsfl_50_idx, sGXsfl_50_idx) ;
            return  ;
         }
         else
         {
            if ( ! IsValidAjaxCall( false) )
            {
               GxWebError = 1 ;
               return  ;
            }
            gxfirstwebparm = gxfirstwebparm_bkp ;
         }
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_7-53786", 0) ;
         Form.Meta.addItem("Description", "Carga Lectiva ", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtCargaLectivaId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public cargalectiva( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public cargalectiva( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITENV( ) ;
         INITTRN( ) ;
         if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("appmasterpage", "GeneXus.Programs.appmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,false);
            MasterPageObj.webExecute();
            if ( context.isAjaxRequest( ) )
            {
               enableOutput();
               if ( ! context.isAjaxRequest( ) )
               {
                  context.GX_webresponse.AppendHeader("Cache-Control", "max-age=0");
               }
               if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) )
               {
                  context.GX_webresponse.AddString((String)(context.getJSONResponse( )));
               }
               else
               {
                  if ( context.isAjaxRequest( ) )
                  {
                     disableOutput();
                  }
                  RenderHtmlHeaders( ) ;
                  context.Redirect( context.wjLoc );
                  context.DispatchAjaxCommands();
               }
            }
         }
         this.cleanup();
      }

      protected void Draw( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! GxWebStd.gx_redirect( context) )
         {
            disable_std_buttons( ) ;
            enableDisable( ) ;
            set_caption( ) ;
            /* Form start */
            wb_table1_2_016( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_016e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_016( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_016( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_016e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Carga Lectiva "+"</legend>") ;
            wb_table3_27_016( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_016e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_016e( true) ;
         }
         else
         {
            wb_table1_2_016e( false) ;
         }
      }

      protected void wb_table3_27_016( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table4_33_016( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_016e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 66,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_CargaLectiva.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 67,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_CargaLectiva.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_CargaLectiva.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_016e( true) ;
         }
         else
         {
            wb_table3_27_016e( false) ;
         }
      }

      protected void wb_table4_33_016( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcargalectivaid_Internalname, "Id", "", "", lblTextblockcargalectivaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CargaLectiva.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCargaLectivaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A18CargaLectivaId), 4, 0, ",", "")), context.localUtil.Format( (decimal)(A18CargaLectivaId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", "", "", "", "", edtCargaLectivaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtCargaLectivaId_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_CargaLectiva.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcargalectivafecha_Internalname, "Fecha", "", "", lblTextblockcargalectivafecha_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CargaLectiva.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19CargaLectivaFecha", context.localUtil.Format(A19CargaLectivaFecha, "99/99/99"));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            context.WriteHtmlText( "<div id=\""+edtCargaLectivaFecha_Internalname+"_dp_container\" class=\"dp_container\" style=\"white-space:nowrap;display:inline;\">") ;
            GxWebStd.gx_single_line_edit( context, edtCargaLectivaFecha_Internalname, context.localUtil.Format(A19CargaLectivaFecha, "99/99/99"), context.localUtil.Format( A19CargaLectivaFecha, "99/99/99"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.date.valid_date(this, 8,'DMY',0,24,'spa',false,0);"+";gx.evt.onblur(43);\"", "", "", "", "", edtCargaLectivaFecha_Jsonclick, 0, ClassString, StyleString, "", 1, edtCargaLectivaFecha_Enabled, 0, 8, "chr", 1, "row", 8, 0, 0, 0, 1, -1, true, "right", "HLP_CargaLectiva.htm");
            GxWebStd.gx_bitmap( context, edtCargaLectivaFecha_Internalname+"_dp_trigger", "calendar-img.gif", "", "", "", "", ((1==0)||(edtCargaLectivaFecha_Enabled==0) ? 0 : 1), 0, "Date selector", "Date selector", 0, 1, 0, "", 0, "", 0, 0, 0, "", "", "cursor: pointer;vertical-align:text-bottom", "", "", "", "", "", "HLP_CargaLectiva.htm");
            context.WriteHtmlTextNl( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"2\" >") ;
            context.WriteHtmlText( "<br>") ;
            wb_table5_46_016( true) ;
         }
         return  ;
      }

      protected void wb_table5_46_016e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<hr class=\"HRDefault\">") ;
            /*  Grid Control  */
            Gridcargalectiva_detalleContainer.AddObjectProperty("GridName", "Gridcargalectiva_detalle");
            Gridcargalectiva_detalleContainer.AddObjectProperty("Class", "Grid");
            Gridcargalectiva_detalleContainer.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(2), 4, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcargalectiva_detalle_Backcolorstyle), 1, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddObjectProperty("CmpContext", "");
            Gridcargalectiva_detalleContainer.AddObjectProperty("InMasterPage", "false");
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42CargaDetalleId), 4, 0, ".", "")));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCargaDetalleId_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4DocenteId), 4, 0, ".", "")));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocenteId_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.RTrim( A5DocenteNombres));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocenteNombres_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ".", "")));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaId_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.RTrim( A23AsignaturaNombre));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaNombre_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11EscuelaId), 4, 0, ".", "")));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEscuelaId_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.RTrim( A12EscuelaNombre));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEscuelaNombre_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.RTrim( A27Grupo));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGrupo_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A28Teoria), 4, 0, ".", "")));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTeoria_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29Practica), 4, 0, ".", "")));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPractica_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A30Laboratorio), 4, 0, ".", "")));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLaboratorio_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A31Total), 4, 0, ".", "")));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTotal_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleColumn = GXWebColumn.GetNew(isAjaxCallMode( )) ;
            Gridcargalectiva_detalleColumn.AddObjectProperty("Value", StringUtil.RTrim( A25Observacion));
            Gridcargalectiva_detalleColumn.AddObjectProperty("Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObservacion_Enabled), 5, 0, ".", "")));
            Gridcargalectiva_detalleContainer.AddColumnProperties(Gridcargalectiva_detalleColumn);
            Gridcargalectiva_detalleContainer.AddObjectProperty("Allowselection", "false");
            Gridcargalectiva_detalleContainer.AddObjectProperty("Allowcollapsing", "false");
            Gridcargalectiva_detalleContainer.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGridcargalectiva_detalle_Collapsed), 9, 0, ".", "")));
            nGXsfl_50_idx = 0 ;
            if ( ( nKeyPressed == 1 ) && ( AnyError == 0 ) )
            {
               /* Enter key processing. */
               nBlankRcdCount15 = 5 ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
               {
                  /* Display confirmed (stored) records */
                  nRcdExists_15 = 1 ;
                  ScanStart0115( ) ;
                  while ( RcdFound15 != 0 )
                  {
                     init_level_properties15( ) ;
                     getByPrimaryKey0115( ) ;
                     AddRow0115( ) ;
                     ScanNext0115( ) ;
                  }
                  ScanEnd0115( ) ;
                  nBlankRcdCount15 = 5 ;
               }
            }
            else if ( ( nKeyPressed == 3 ) || ( nKeyPressed == 4 ) || ( ( nKeyPressed == 1 ) && ( AnyError != 0 ) ) )
            {
               /* Button check  or addlines. */
               standaloneNotModal0115( ) ;
               standaloneModal0115( ) ;
               sMode15 = Gx_mode ;
               while ( nGXsfl_50_idx < nRC_Gridcargalectiva_detalle )
               {
                  ReadRow0115( ) ;
                  edtCargaDetalleId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CARGADETALLEID_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargaDetalleId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargaDetalleId_Enabled), 5, 0)));
                  edtDocenteId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCENTEID_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteId_Enabled), 5, 0)));
                  edtDocenteNombres_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCENTENOMBRES_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteNombres_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteNombres_Enabled), 5, 0)));
                  edtAsignaturaId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURAID_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)));
                  edtAsignaturaNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURANOMBRE_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)));
                  edtEscuelaId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESCUELAID_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEscuelaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEscuelaId_Enabled), 5, 0)));
                  edtEscuelaNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESCUELANOMBRE_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEscuelaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEscuelaNombre_Enabled), 5, 0)));
                  edtGrupo_Enabled = (int)(context.localUtil.CToN( cgiGet( "GRUPO_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGrupo_Enabled), 5, 0)));
                  edtTeoria_Enabled = (int)(context.localUtil.CToN( cgiGet( "TEORIA_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTeoria_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTeoria_Enabled), 5, 0)));
                  edtPractica_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRACTICA_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPractica_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPractica_Enabled), 5, 0)));
                  edtLaboratorio_Enabled = (int)(context.localUtil.CToN( cgiGet( "LABORATORIO_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtLaboratorio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtLaboratorio_Enabled), 5, 0)));
                  edtTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "TOTAL_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTotal_Enabled), 5, 0)));
                  edtObservacion_Enabled = (int)(context.localUtil.CToN( cgiGet( "OBSERVACION_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObservacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObservacion_Enabled), 5, 0)));
                  imgprompt_4_Link = cgiGet( "PROMPT_4_"+sGXsfl_50_idx+"Link") ;
                  imgprompt_4_Link = cgiGet( "PROMPT_22_"+sGXsfl_50_idx+"Link") ;
                  imgprompt_4_Link = cgiGet( "PROMPT_11_"+sGXsfl_50_idx+"Link") ;
                  if ( ( nRcdExists_15 == 0 ) && ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     standaloneModal0115( ) ;
                  }
                  SendRow0115( ) ;
               }
               Gx_mode = sMode15 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            }
            else
            {
               /* Get or get-alike key processing. */
               nBlankRcdCount15 = 5 ;
               nRcdExists_15 = 1 ;
               ScanStart0115( ) ;
               while ( RcdFound15 != 0 )
               {
                  init_level_properties15( ) ;
                  getByPrimaryKey0115( ) ;
                  standaloneNotModal0115( ) ;
                  standaloneModal0115( ) ;
                  AddRow0115( ) ;
                  ScanNext0115( ) ;
               }
               ScanEnd0115( ) ;
            }
            /* Initialize fields for 'new' records and send them. */
            sMode15 = Gx_mode ;
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            InitAll0115( ) ;
            init_level_properties15( ) ;
            standaloneNotModal0115( ) ;
            standaloneModal0115( ) ;
            nRcdExists_15 = 0 ;
            nIsMod_15 = 0 ;
            nBlankRcdCount15 = (short)(nBlankRcdUsr15+nBlankRcdCount15) ;
            fRowAdded = 0 ;
            while ( nBlankRcdCount15 > 0 )
            {
               AddRow0115( ) ;
               if ( ( nKeyPressed == 4 ) && ( fRowAdded == 0 ) )
               {
                  fRowAdded = 1 ;
                  GX_FocusControl = edtCargaDetalleId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               nBlankRcdCount15 = (short)(nBlankRcdCount15-1) ;
            }
            Gx_mode = sMode15 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            sStyleString = " style=\"display:none;\"" ;
            sStyleString = "" ;
            context.WriteHtmlText( "<div id=\""+"Gridcargalectiva_detalleContainer"+"Div\" "+sStyleString+">"+"</div>") ;
            context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Gridcargalectiva_detalle", (Object)(Gridcargalectiva_detalleContainer));
            GxWebStd.gx_hidden_field( context, "Gridcargalectiva_detalleContainerData", Gridcargalectiva_detalleContainer.ToJavascriptSource());
            if ( context.isAjaxRequest( ) )
            {
               GxWebStd.gx_hidden_field( context, "Gridcargalectiva_detalleContainerData"+"V", Gridcargalectiva_detalleContainer.GridValuesHidden());
            }
            else
            {
               context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Gridcargalectiva_detalleContainerData"+"V"+"\" value='"+Gridcargalectiva_detalleContainer.GridValuesHidden()+"'>") ;
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_016e( true) ;
         }
         else
         {
            wb_table4_33_016e( false) ;
         }
      }

      protected void wb_table5_46_016( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table95", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td class=\"SubTitle\" >") ;
            /* Text block */
            ClassString = "" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTitledetalle_Internalname, "Detalle", "", "", lblTitledetalle_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_CargaLectiva.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_46_016e( true) ;
         }
         else
         {
            wb_table5_46_016e( false) ;
         }
      }

      protected void wb_table2_5_016( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTabletoolbar_Internalname, tblTabletoolbar_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "<div style=\"WHITE-SPACE: nowrap\" class=\"ToolbarMain\">") ;
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 8,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "", "", "", "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "", "", "", "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "", "", "", "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "", "", "", "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "", "", "", "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0060.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CARGALECTIVAID"+"'), id:'"+"CARGALECTIVAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx0060.aspx"+"',["+"{Ctrl:gx.dom.el('"+"CARGALECTIVAID"+"'), id:'"+"CARGALECTIVAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "", "", "", "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "", "", "", "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "", "", "", "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_CargaLectiva.htm");
            context.WriteHtmlText( "</div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_016e( true) ;
         }
         else
         {
            wb_table2_5_016e( false) ;
         }
      }

      protected void UserMain( )
      {
         standaloneStartup( ) ;
      }

      protected void standaloneStartup( )
      {
         standaloneStartupServer( ) ;
         disable_std_buttons( ) ;
         enableDisable( ) ;
         Process( ) ;
      }

      protected void standaloneStartupServer( )
      {
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         context.wbGlbDoneStart = 1 ;
         assign_properties_default( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
            {
               /* Read saved SDTs. */
               /* Read variables values. */
               if ( ( ( context.localUtil.CToN( cgiGet( edtCargaLectivaId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCargaLectivaId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "CARGALECTIVAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCargaLectivaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A18CargaLectivaId = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
               }
               else
               {
                  A18CargaLectivaId = (short)(context.localUtil.CToN( cgiGet( edtCargaLectivaId_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
               }
               if ( context.localUtil.VCDate( cgiGet( edtCargaLectivaFecha_Internalname), 2) == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_faildate", new   object[]  {"Fecha"}), 1, "CARGALECTIVAFECHA");
                  AnyError = 1 ;
                  GX_FocusControl = edtCargaLectivaFecha_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A19CargaLectivaFecha = DateTime.MinValue ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19CargaLectivaFecha", context.localUtil.Format(A19CargaLectivaFecha, "99/99/99"));
               }
               else
               {
                  A19CargaLectivaFecha = context.localUtil.CToD( cgiGet( edtCargaLectivaFecha_Internalname), 2) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19CargaLectivaFecha", context.localUtil.Format(A19CargaLectivaFecha, "99/99/99"));
               }
               /* Read saved values. */
               Z18CargaLectivaId = (short)(context.localUtil.CToN( cgiGet( "Z18CargaLectivaId"), ",", ".")) ;
               Z19CargaLectivaFecha = context.localUtil.CToD( cgiGet( "Z19CargaLectivaFecha"), 0) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
               nRC_Gridcargalectiva_detalle = (short)(context.localUtil.CToN( cgiGet( "nRC_Gridcargalectiva_detalle"), ",", ".")) ;
               Gx_mode = cgiGet( "vMODE") ;
               /* Read subfile selected row values. */
               /* Read hidden variables. */
               standaloneNotModal( ) ;
            }
            else
            {
               standaloneNotModal( ) ;
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") == 0 )
               {
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  A18CargaLectivaId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
                  getEqualNoModal( ) ;
                  Gx_mode = "DSP" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  disable_std_buttons_dsp( ) ;
                  standaloneModal( ) ;
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  standaloneModal( ) ;
               }
            }
         }
      }

      protected void Process( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read Transaction buttons. */
            sEvt = cgiGet( "_EventName") ;
            EvtGridId = cgiGet( "_EventGridId") ;
            EvtRowId = cgiGet( "_EventRowId") ;
            if ( StringUtil.Len( sEvt) > 0 )
            {
               sEvtType = StringUtil.Left( sEvt, 1) ;
               sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
               /* Check if conditions changed and reset current page numbers */
               if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
               {
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_enter( ) ;
                           /* No code required for Cancel button. It is implemented as the Reset button. */
                        }
                        else if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_first( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "PREVIOUS") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_previous( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_next( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_last( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "SELECT") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_select( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "DELETE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           btn_delete( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                        {
                           context.wbHandled = 1 ;
                           AfterKeyLoadScreen( ) ;
                        }
                     }
                     else
                     {
                        sEvtType = StringUtil.Right( sEvt, 4) ;
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                     }
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            trnEnded = 0 ;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               /* Clear variables for new insertion. */
               InitAll016( ) ;
               standaloneNotModal( ) ;
               standaloneModal( ) ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      protected void disable_std_buttons( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void disable_std_buttons_dsp( )
      {
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         imgBtn_first_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_Visible), 5, 0)));
         imgBtn_first_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_first_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_first_separator_Visible), 5, 0)));
         imgBtn_previous_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_Visible), 5, 0)));
         imgBtn_previous_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_previous_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_previous_separator_Visible), 5, 0)));
         imgBtn_next_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_Visible), 5, 0)));
         imgBtn_next_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_next_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_next_separator_Visible), 5, 0)));
         imgBtn_last_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_Visible), 5, 0)));
         imgBtn_last_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_last_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_last_separator_Visible), 5, 0)));
         imgBtn_select_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_Visible), 5, 0)));
         imgBtn_select_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_select_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_select_separator_Visible), 5, 0)));
         imgBtn_delete2_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Visible), 5, 0)));
         imgBtn_delete2_separator_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_separator_Visible), 5, 0)));
         bttBtn_delete_Visible = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_delete_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_delete_Visible), 5, 0)));
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Visible), 5, 0)));
            imgBtn_enter2_separator_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_separator_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_separator_Visible), 5, 0)));
            bttBtn_enter_Visible = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, bttBtn_enter_Internalname, "Visible", StringUtil.LTrim( StringUtil.Str( (decimal)(bttBtn_enter_Visible), 5, 0)));
         }
         DisableAttributes016( ) ;
      }

      protected void set_caption( )
      {
         if ( ( IsConfirmed == 1 ) && ( AnyError == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_confdelete"), 0, "");
            }
            else
            {
               GX_msglist.addItem(context.GetMessage( "GXM_mustconfirm"), 0, "");
            }
         }
      }

      protected void CONFIRM_0115( )
      {
         nGXsfl_50_idx = 0 ;
         while ( nGXsfl_50_idx < nRC_Gridcargalectiva_detalle )
         {
            ReadRow0115( ) ;
            if ( ( nRcdExists_15 != 0 ) || ( nIsMod_15 != 0 ) )
            {
               GetKey0115( ) ;
               if ( ( nRcdExists_15 == 0 ) && ( nRcdDeleted_15 == 0 ) )
               {
                  if ( RcdFound15 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     BeforeValidate0115( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0115( ) ;
                        CloseExtendedTableCursors0115( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1 ;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtCargaDetalleId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound15 != 0 )
                  {
                     if ( nRcdDeleted_15 != 0 )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        getByPrimaryKey0115( ) ;
                        Load0115( ) ;
                        BeforeValidate0115( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0115( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_15 != 0 )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           BeforeValidate0115( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0115( ) ;
                              CloseExtendedTableCursors0115( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1 ;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_15 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtCargaDetalleId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCargaDetalleId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42CargaDetalleId), 4, 0, ",", ""))) ;
            ChangePostValue( edtDocenteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4DocenteId), 4, 0, ",", ""))) ;
            ChangePostValue( edtDocenteNombres_Internalname, StringUtil.RTrim( A5DocenteNombres)) ;
            ChangePostValue( edtAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ",", ""))) ;
            ChangePostValue( edtAsignaturaNombre_Internalname, StringUtil.RTrim( A23AsignaturaNombre)) ;
            ChangePostValue( edtEscuelaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11EscuelaId), 4, 0, ",", ""))) ;
            ChangePostValue( edtEscuelaNombre_Internalname, StringUtil.RTrim( A12EscuelaNombre)) ;
            ChangePostValue( edtGrupo_Internalname, StringUtil.RTrim( A27Grupo)) ;
            ChangePostValue( edtTeoria_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28Teoria), 4, 0, ",", ""))) ;
            ChangePostValue( edtPractica_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A29Practica), 4, 0, ",", ""))) ;
            ChangePostValue( edtLaboratorio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A30Laboratorio), 4, 0, ",", ""))) ;
            ChangePostValue( edtTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A31Total), 4, 0, ",", ""))) ;
            ChangePostValue( edtObservacion_Internalname, StringUtil.RTrim( A25Observacion)) ;
            ChangePostValue( "ZT_"+"Z42CargaDetalleId_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42CargaDetalleId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z27Grupo_"+sGXsfl_50_idx, StringUtil.RTrim( Z27Grupo)) ;
            ChangePostValue( "ZT_"+"Z28Teoria_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28Teoria), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z29Practica_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29Practica), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z30Laboratorio_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30Laboratorio), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z25Observacion_"+sGXsfl_50_idx, StringUtil.RTrim( Z25Observacion)) ;
            ChangePostValue( "ZT_"+"Z4DocenteId_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4DocenteId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z22AsignaturaId_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22AsignaturaId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z11EscuelaId_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11EscuelaId), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_15_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_15_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_15_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ",", ""))) ;
            if ( nIsMod_15 != 0 )
            {
               ChangePostValue( "CARGADETALLEID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCargaDetalleId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DOCENTEID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocenteId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DOCENTENOMBRES_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocenteNombres_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ASIGNATURAID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ASIGNATURANOMBRE_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ESCUELAID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEscuelaId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ESCUELANOMBRE_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEscuelaNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "GRUPO_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGrupo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TEORIA_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTeoria_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRACTICA_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPractica_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LABORATORIO_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLaboratorio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TOTAL_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTotal_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBSERVACION_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObservacion_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void ResetCaption010( )
      {
      }

      protected void ZM016( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z19CargaLectivaFecha = T00018_A19CargaLectivaFecha[0] ;
            }
            else
            {
               Z19CargaLectivaFecha = A19CargaLectivaFecha ;
            }
         }
         if ( GX_JID == -3 )
         {
            Z18CargaLectivaId = A18CargaLectivaId ;
            Z19CargaLectivaFecha = A19CargaLectivaFecha ;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 )
         {
            imgBtn_enter2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_enter2_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_enter2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_enter2_Enabled), 5, 0)));
         }
      }

      protected void Load016( )
      {
         /* Using cursor T00019 */
         pr_default.execute(7, new Object[] {A18CargaLectivaId});
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound6 = 1 ;
            A19CargaLectivaFecha = T00019_A19CargaLectivaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19CargaLectivaFecha", context.localUtil.Format(A19CargaLectivaFecha, "99/99/99"));
            ZM016( -3) ;
         }
         pr_default.close(7);
         OnLoadActions016( ) ;
      }

      protected void OnLoadActions016( )
      {
      }

      protected void CheckExtendedTable016( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A19CargaLectivaFecha) || ( A19CargaLectivaFecha >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Campo Fecha fuera de rango", "OutOfRange", 1, "");
            AnyError = 1 ;
         }
      }

      protected void CloseExtendedTableCursors016( )
      {
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound6 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void GetKey016( )
      {
         /* Using cursor T000110 */
         pr_default.execute(8, new Object[] {A18CargaLectivaId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound6 = 1 ;
         }
         else
         {
            RcdFound6 = 0 ;
         }
         pr_default.close(8);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00018 */
         pr_default.execute(6, new Object[] {A18CargaLectivaId});
         if ( (pr_default.getStatus(6) != 101) )
         {
            ZM016( 3) ;
            RcdFound6 = 1 ;
            A18CargaLectivaId = T00018_A18CargaLectivaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
            A19CargaLectivaFecha = T00018_A19CargaLectivaFecha[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19CargaLectivaFecha", context.localUtil.Format(A19CargaLectivaFecha, "99/99/99"));
            Z18CargaLectivaId = A18CargaLectivaId ;
            sMode6 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load016( ) ;
            Gx_mode = sMode6 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound6 = 0 ;
            InitializeNonKey016( ) ;
            sMode6 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode6 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(6);
      }

      protected void getEqualNoModal( )
      {
         GetKey016( ) ;
         if ( RcdFound6 == 0 )
         {
            Gx_mode = "INS" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
      }

      protected void move_next( )
      {
         RcdFound6 = 0 ;
         /* Using cursor T000111 */
         pr_default.execute(9, new Object[] {A18CargaLectivaId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            while ( (pr_default.getStatus(9) != 101) && ( ( T000111_A18CargaLectivaId[0] < A18CargaLectivaId ) ) )
            {
               pr_default.readNext(9);
            }
            if ( (pr_default.getStatus(9) != 101) && ( ( T000111_A18CargaLectivaId[0] > A18CargaLectivaId ) ) )
            {
               A18CargaLectivaId = T000111_A18CargaLectivaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
               RcdFound6 = 1 ;
            }
         }
         pr_default.close(6);
      }

      protected void move_previous( )
      {
         RcdFound6 = 0 ;
         /* Using cursor T000112 */
         pr_default.execute(10, new Object[] {A18CargaLectivaId});
         if ( (pr_default.getStatus(10) != 101) )
         {
            while ( (pr_default.getStatus(10) != 101) && ( ( T000112_A18CargaLectivaId[0] > A18CargaLectivaId ) ) )
            {
               pr_default.readNext(10);
            }
            if ( (pr_default.getStatus(10) != 101) && ( ( T000112_A18CargaLectivaId[0] < A18CargaLectivaId ) ) )
            {
               A18CargaLectivaId = T000112_A18CargaLectivaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
               RcdFound6 = 1 ;
            }
         }
         pr_default.close(5);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey016( ) ;
         if ( RcdFound6 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "CARGALECTIVAID");
               AnyError = 1 ;
               GX_FocusControl = edtCargaLectivaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A18CargaLectivaId != Z18CargaLectivaId )
            {
               A18CargaLectivaId = Z18CargaLectivaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "CARGALECTIVAID");
               AnyError = 1 ;
               GX_FocusControl = edtCargaLectivaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtCargaLectivaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update016( ) ;
               GX_FocusControl = edtCargaLectivaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A18CargaLectivaId != Z18CargaLectivaId )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtCargaLectivaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert016( ) ;
               if ( AnyError == 1 )
               {
                  GX_FocusControl = "" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "CARGALECTIVAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtCargaLectivaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtCargaLectivaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert016( ) ;
                  if ( AnyError == 1 )
                  {
                     GX_FocusControl = "" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      protected void btn_delete( )
      {
         if ( A18CargaLectivaId != Z18CargaLectivaId )
         {
            A18CargaLectivaId = Z18CargaLectivaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "CARGALECTIVAID");
            AnyError = 1 ;
            GX_FocusControl = edtCargaLectivaId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtCargaLectivaId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError != 0 )
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         getByPrimaryKey( ) ;
         CloseOpenCursors();
      }

      protected void btn_get( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "CARGALECTIVAID");
            AnyError = 1 ;
         }
         GX_FocusControl = edtCargaLectivaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart016( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCargaLectivaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd016( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCargaLectivaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_next( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_next( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCargaLectivaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart016( ) ;
         if ( RcdFound6 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound6 != 0 )
            {
               ScanNext016( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtCargaLectivaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd016( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency016( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T000113 */
            pr_default.execute(11, new Object[] {A18CargaLectivaId});
            if ( (pr_default.getStatus(11) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CargaLectiva"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            if ( (pr_default.getStatus(11) == 101) || ( Z19CargaLectivaFecha != T000113_A19CargaLectivaFecha[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CargaLectiva"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert016( )
      {
         BeforeValidate016( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable016( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM016( 0) ;
            CheckOptimisticConcurrency016( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm016( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert016( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000114 */
                     pr_default.execute(12, new Object[] {A19CargaLectivaFecha});
                     pr_default.close(12);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000115 */
                     pr_default.execute(13);
                     A18CargaLectivaId = T000115_A18CargaLectivaId[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
                     pr_default.close(13);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel016( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                              ResetCaption010( ) ;
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load016( ) ;
            }
            EndLevel016( ) ;
         }
         CloseExtendedTableCursors016( ) ;
      }

      protected void Update016( )
      {
         BeforeValidate016( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable016( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency016( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm016( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate016( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000116 */
                     pr_default.execute(14, new Object[] {A19CargaLectivaFecha, A18CargaLectivaId});
                     pr_default.close(14);
                     if ( (pr_default.getStatus(14) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CargaLectiva"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate016( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel016( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                              ResetCaption010( ) ;
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel016( ) ;
         }
         CloseExtendedTableCursors016( ) ;
      }

      protected void DeferredUpdate016( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate016( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency016( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls016( ) ;
            AfterConfirm016( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete016( ) ;
               if ( AnyError == 0 )
               {
                  ScanStart0115( ) ;
                  while ( RcdFound15 != 0 )
                  {
                     getByPrimaryKey0115( ) ;
                     Delete0115( ) ;
                     ScanNext0115( ) ;
                  }
                  ScanEnd0115( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000117 */
                     pr_default.execute(15, new Object[] {A18CargaLectivaId});
                     pr_default.close(15);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           move_next( ) ;
                           if ( RcdFound6 == 0 )
                           {
                              InitAll016( ) ;
                              Gx_mode = "INS" ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           else
                           {
                              getByPrimaryKey( ) ;
                              Gx_mode = "UPD" ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           }
                           GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted"), 0, "");
                           ResetCaption010( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
         }
         sMode6 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel016( ) ;
         Gx_mode = sMode6 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls016( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void ProcessNestedLevel0115( )
      {
         nGXsfl_50_idx = 0 ;
         while ( nGXsfl_50_idx < nRC_Gridcargalectiva_detalle )
         {
            ReadRow0115( ) ;
            if ( ( nRcdExists_15 != 0 ) || ( nIsMod_15 != 0 ) )
            {
               standaloneNotModal0115( ) ;
               GetKey0115( ) ;
               if ( ( nRcdExists_15 == 0 ) && ( nRcdDeleted_15 == 0 ) )
               {
                  if ( RcdFound15 == 0 )
                  {
                     Gx_mode = "INS" ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                     Insert0115( ) ;
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1 ;
                     GX_FocusControl = edtCargaDetalleId_Internalname ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  }
               }
               else
               {
                  if ( RcdFound15 != 0 )
                  {
                     if ( ( nRcdDeleted_15 != 0 ) && ( nRcdExists_15 != 0 ) )
                     {
                        Gx_mode = "DLT" ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                        Delete0115( ) ;
                     }
                     else
                     {
                        if ( ( nIsMod_15 != 0 ) && ( nRcdExists_15 != 0 ) )
                        {
                           Gx_mode = "UPD" ;
                           context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                           Update0115( ) ;
                        }
                     }
                  }
                  else
                  {
                     if ( nRcdDeleted_15 == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "");
                        AnyError = 1 ;
                        GX_FocusControl = edtCargaDetalleId_Internalname ;
                        context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                     }
                  }
               }
            }
            ChangePostValue( edtCargaDetalleId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A42CargaDetalleId), 4, 0, ",", ""))) ;
            ChangePostValue( edtDocenteId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A4DocenteId), 4, 0, ",", ""))) ;
            ChangePostValue( edtDocenteNombres_Internalname, StringUtil.RTrim( A5DocenteNombres)) ;
            ChangePostValue( edtAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ",", ""))) ;
            ChangePostValue( edtAsignaturaNombre_Internalname, StringUtil.RTrim( A23AsignaturaNombre)) ;
            ChangePostValue( edtEscuelaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A11EscuelaId), 4, 0, ",", ""))) ;
            ChangePostValue( edtEscuelaNombre_Internalname, StringUtil.RTrim( A12EscuelaNombre)) ;
            ChangePostValue( edtGrupo_Internalname, StringUtil.RTrim( A27Grupo)) ;
            ChangePostValue( edtTeoria_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A28Teoria), 4, 0, ",", ""))) ;
            ChangePostValue( edtPractica_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A29Practica), 4, 0, ",", ""))) ;
            ChangePostValue( edtLaboratorio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A30Laboratorio), 4, 0, ",", ""))) ;
            ChangePostValue( edtTotal_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A31Total), 4, 0, ",", ""))) ;
            ChangePostValue( edtObservacion_Internalname, StringUtil.RTrim( A25Observacion)) ;
            ChangePostValue( "ZT_"+"Z42CargaDetalleId_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42CargaDetalleId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z27Grupo_"+sGXsfl_50_idx, StringUtil.RTrim( Z27Grupo)) ;
            ChangePostValue( "ZT_"+"Z28Teoria_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28Teoria), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z29Practica_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29Practica), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z30Laboratorio_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30Laboratorio), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z25Observacion_"+sGXsfl_50_idx, StringUtil.RTrim( Z25Observacion)) ;
            ChangePostValue( "ZT_"+"Z4DocenteId_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4DocenteId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z22AsignaturaId_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22AsignaturaId), 4, 0, ",", ""))) ;
            ChangePostValue( "ZT_"+"Z11EscuelaId_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11EscuelaId), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdDeleted_15_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ",", ""))) ;
            ChangePostValue( "nRcdExists_15_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ",", ""))) ;
            ChangePostValue( "nIsMod_15_"+sGXsfl_50_idx, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ",", ""))) ;
            if ( nIsMod_15 != 0 )
            {
               ChangePostValue( "CARGADETALLEID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCargaDetalleId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DOCENTEID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocenteId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "DOCENTENOMBRES_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocenteNombres_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ASIGNATURAID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ASIGNATURANOMBRE_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ESCUELAID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEscuelaId_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "ESCUELANOMBRE_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEscuelaNombre_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "GRUPO_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGrupo_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TEORIA_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTeoria_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "PRACTICA_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPractica_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "LABORATORIO_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLaboratorio_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "TOTAL_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTotal_Enabled), 5, 0, ".", ""))) ;
               ChangePostValue( "OBSERVACION_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObservacion_Enabled), 5, 0, ".", ""))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0115( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_15 = 0 ;
         nIsMod_15 = 0 ;
         nRcdDeleted_15 = 0 ;
      }

      protected void ProcessLevel016( )
      {
         /* Save parent mode. */
         sMode6 = Gx_mode ;
         ProcessNestedLevel0115( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode6 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         /* ' Update level parameters */
      }

      protected void EndLevel016( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(11);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete016( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(10);
            pr_default.close(9);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            pr_default.close(3);
            pr_default.close(4);
            context.CommitDataStores("CargaLectiva");
            if ( AnyError == 0 )
            {
               ConfirmValues010( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(10);
            pr_default.close(9);
            pr_default.close(1);
            pr_default.close(0);
            pr_default.close(2);
            pr_default.close(3);
            pr_default.close(4);
            context.RollbackDataStores("CargaLectiva");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart016( )
      {
         /* Using cursor T000118 */
         pr_default.execute(16);
         RcdFound6 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound6 = 1 ;
            A18CargaLectivaId = T000118_A18CargaLectivaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext016( )
      {
         pr_default.readNext(16);
         RcdFound6 = 0 ;
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound6 = 1 ;
            A18CargaLectivaId = T000118_A18CargaLectivaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
         }
      }

      protected void ScanEnd016( )
      {
      }

      protected void AfterConfirm016( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert016( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate016( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete016( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete016( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate016( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes016( )
      {
         edtCargaLectivaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargaLectivaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargaLectivaId_Enabled), 5, 0)));
         edtCargaLectivaFecha_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargaLectivaFecha_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargaLectivaFecha_Enabled), 5, 0)));
      }

      protected void ZM0115( short GX_JID )
      {
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z27Grupo = T00013_A27Grupo[0] ;
               Z28Teoria = T00013_A28Teoria[0] ;
               Z29Practica = T00013_A29Practica[0] ;
               Z30Laboratorio = T00013_A30Laboratorio[0] ;
               Z25Observacion = T00013_A25Observacion[0] ;
               Z4DocenteId = T00013_A4DocenteId[0] ;
               Z22AsignaturaId = T00013_A22AsignaturaId[0] ;
               Z11EscuelaId = T00013_A11EscuelaId[0] ;
            }
            else
            {
               Z27Grupo = A27Grupo ;
               Z28Teoria = A28Teoria ;
               Z29Practica = A29Practica ;
               Z30Laboratorio = A30Laboratorio ;
               Z25Observacion = A25Observacion ;
               Z4DocenteId = A4DocenteId ;
               Z22AsignaturaId = A22AsignaturaId ;
               Z11EscuelaId = A11EscuelaId ;
            }
         }
         if ( GX_JID == -4 )
         {
            Z18CargaLectivaId = A18CargaLectivaId ;
            Z42CargaDetalleId = A42CargaDetalleId ;
            Z27Grupo = A27Grupo ;
            Z28Teoria = A28Teoria ;
            Z29Practica = A29Practica ;
            Z30Laboratorio = A30Laboratorio ;
            Z25Observacion = A25Observacion ;
            Z4DocenteId = A4DocenteId ;
            Z22AsignaturaId = A22AsignaturaId ;
            Z11EscuelaId = A11EscuelaId ;
            Z5DocenteNombres = A5DocenteNombres ;
            Z23AsignaturaNombre = A23AsignaturaNombre ;
            Z12EscuelaNombre = A12EscuelaNombre ;
         }
      }

      protected void standaloneNotModal0115( )
      {
      }

      protected void standaloneModal0115( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            edtCargaDetalleId_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargaDetalleId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargaDetalleId_Enabled), 5, 0)));
         }
         else
         {
            edtCargaDetalleId_Enabled = 1 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargaDetalleId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargaDetalleId_Enabled), 5, 0)));
         }
         if ( ( StringUtil.StrCmp(sMode15, "DSP") == 0 ) || ( StringUtil.StrCmp(sMode15, "DLT") == 0 ) )
         {
            DisableAttributes0115( ) ;
         }
      }

      protected void Load0115( )
      {
         /* Using cursor T000119 */
         pr_default.execute(17, new Object[] {A18CargaLectivaId, A42CargaDetalleId});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound15 = 1 ;
            A5DocenteNombres = T000119_A5DocenteNombres[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5DocenteNombres", A5DocenteNombres);
            A23AsignaturaNombre = T000119_A23AsignaturaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
            A12EscuelaNombre = T000119_A12EscuelaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12EscuelaNombre", A12EscuelaNombre);
            A27Grupo = T000119_A27Grupo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27Grupo", A27Grupo);
            A28Teoria = T000119_A28Teoria[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28Teoria", StringUtil.LTrim( StringUtil.Str( (decimal)(A28Teoria), 4, 0)));
            A29Practica = T000119_A29Practica[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29Practica", StringUtil.LTrim( StringUtil.Str( (decimal)(A29Practica), 4, 0)));
            A30Laboratorio = T000119_A30Laboratorio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30Laboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(A30Laboratorio), 4, 0)));
            A25Observacion = T000119_A25Observacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25Observacion", A25Observacion);
            A4DocenteId = T000119_A4DocenteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
            A22AsignaturaId = T000119_A22AsignaturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
            A11EscuelaId = T000119_A11EscuelaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EscuelaId), 4, 0)));
            ZM0115( -4) ;
         }
         pr_default.close(17);
         OnLoadActions0115( ) ;
      }

      protected void OnLoadActions0115( )
      {
         A31Total = (short)(A28Teoria+A29Practica+A30Laboratorio) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31Total", StringUtil.LTrim( StringUtil.Str( (decimal)(A31Total), 4, 0)));
      }

      protected void CheckExtendedTable0115( )
      {
         Gx_BScreen = 1 ;
         standaloneModal0115( ) ;
         /* Using cursor T00014 */
         pr_default.execute(2, new Object[] {A4DocenteId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Docente'.", "ForeignKeyNotFound", 1, "DOCENTEID");
            AnyError = 1 ;
            GX_FocusControl = edtDocenteId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError4 == 0 )
         {
            A5DocenteNombres = T00014_A5DocenteNombres[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5DocenteNombres", A5DocenteNombres);
         }
         pr_default.close(2);
         /* Using cursor T00015 */
         pr_default.execute(3, new Object[] {A22AsignaturaId});
         if ( (pr_default.getStatus(3) == 101) )
         {
            AnyError22 = 1 ;
            GX_msglist.addItem("No existe 'Asignatura'.", "ForeignKeyNotFound", 1, "ASIGNATURAID");
            AnyError = 1 ;
            GX_FocusControl = edtAsignaturaId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError22 == 0 )
         {
            A23AsignaturaNombre = T00015_A23AsignaturaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
         }
         pr_default.close(3);
         /* Using cursor T00016 */
         pr_default.execute(4, new Object[] {A11EscuelaId});
         if ( (pr_default.getStatus(4) == 101) )
         {
            AnyError11 = 1 ;
            GX_msglist.addItem("No existe 'Escuela'.", "ForeignKeyNotFound", 1, "ESCUELAID");
            AnyError = 1 ;
            GX_FocusControl = edtEscuelaId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError11 == 0 )
         {
            A12EscuelaNombre = T00016_A12EscuelaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12EscuelaNombre", A12EscuelaNombre);
         }
         pr_default.close(4);
         A31Total = (short)(A28Teoria+A29Practica+A30Laboratorio) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31Total", StringUtil.LTrim( StringUtil.Str( (decimal)(A31Total), 4, 0)));
      }

      protected void CloseExtendedTableCursors0115( )
      {
         pr_default.close(2);
         pr_default.close(3);
         pr_default.close(4);
      }

      protected void enableDisable0115( )
      {
      }

      protected void gxLoad_5( short A4DocenteId )
      {
         /* Using cursor T000120 */
         pr_default.execute(18, new Object[] {A4DocenteId});
         if ( (pr_default.getStatus(18) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Docente'.", "ForeignKeyNotFound", 1, "DOCENTEID");
            AnyError = 1 ;
            GX_FocusControl = edtDocenteId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError4 == 0 )
         {
            A5DocenteNombres = T000120_A5DocenteNombres[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5DocenteNombres", A5DocenteNombres);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A5DocenteNombres))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(18) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(18);
      }

      protected void gxLoad_6( short A22AsignaturaId )
      {
         /* Using cursor T000121 */
         pr_default.execute(19, new Object[] {A22AsignaturaId});
         if ( (pr_default.getStatus(19) == 101) )
         {
            AnyError22 = 1 ;
            GX_msglist.addItem("No existe 'Asignatura'.", "ForeignKeyNotFound", 1, "ASIGNATURAID");
            AnyError = 1 ;
            GX_FocusControl = edtAsignaturaId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError22 == 0 )
         {
            A23AsignaturaNombre = T000121_A23AsignaturaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A23AsignaturaNombre))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(19) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(19);
      }

      protected void gxLoad_7( short A11EscuelaId )
      {
         /* Using cursor T000122 */
         pr_default.execute(20, new Object[] {A11EscuelaId});
         if ( (pr_default.getStatus(20) == 101) )
         {
            AnyError11 = 1 ;
            GX_msglist.addItem("No existe 'Escuela'.", "ForeignKeyNotFound", 1, "ESCUELAID");
            AnyError = 1 ;
            GX_FocusControl = edtEscuelaId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         if ( AnyError11 == 0 )
         {
            A12EscuelaNombre = T000122_A12EscuelaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12EscuelaNombre", A12EscuelaNombre);
         }
         GxWebStd.set_html_headers( context, 0, "", "");
         context.GX_webresponse.AddString("new Array( new Array(");
         context.GX_webresponse.AddString("\""+GXUtil.EncodeJSConstant( StringUtil.RTrim( A12EscuelaNombre))+"\"");
         context.GX_webresponse.AddString(")");
         if ( (pr_default.getStatus(20) == 101) )
         {
            context.GX_webresponse.AddString(",");
            context.GX_webresponse.AddString("101");
         }
         context.GX_webresponse.AddString(")");
         pr_default.close(20);
      }

      protected void GetKey0115( )
      {
         /* Using cursor T000123 */
         pr_default.execute(21, new Object[] {A18CargaLectivaId, A42CargaDetalleId});
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound15 = 1 ;
         }
         else
         {
            RcdFound15 = 0 ;
         }
         pr_default.close(21);
      }

      protected void getByPrimaryKey0115( )
      {
         /* Using cursor T00013 */
         pr_default.execute(1, new Object[] {A18CargaLectivaId, A42CargaDetalleId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0115( 4) ;
            RcdFound15 = 1 ;
            InitializeNonKey0115( ) ;
            A42CargaDetalleId = T00013_A42CargaDetalleId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42CargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A42CargaDetalleId), 4, 0)));
            A27Grupo = T00013_A27Grupo[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27Grupo", A27Grupo);
            A28Teoria = T00013_A28Teoria[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28Teoria", StringUtil.LTrim( StringUtil.Str( (decimal)(A28Teoria), 4, 0)));
            A29Practica = T00013_A29Practica[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29Practica", StringUtil.LTrim( StringUtil.Str( (decimal)(A29Practica), 4, 0)));
            A30Laboratorio = T00013_A30Laboratorio[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30Laboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(A30Laboratorio), 4, 0)));
            A25Observacion = T00013_A25Observacion[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25Observacion", A25Observacion);
            A4DocenteId = T00013_A4DocenteId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
            A22AsignaturaId = T00013_A22AsignaturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
            A11EscuelaId = T00013_A11EscuelaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EscuelaId), 4, 0)));
            Z18CargaLectivaId = A18CargaLectivaId ;
            Z42CargaDetalleId = A42CargaDetalleId ;
            sMode15 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0115( ) ;
            Load0115( ) ;
            Gx_mode = sMode15 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound15 = 0 ;
            InitializeNonKey0115( ) ;
            sMode15 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal0115( ) ;
            Gx_mode = sMode15 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0115( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00012 */
            pr_default.execute(0, new Object[] {A18CargaLectivaId, A42CargaDetalleId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CargaLectivaCargaDetalle"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z27Grupo, T00012_A27Grupo[0]) != 0 ) || ( Z28Teoria != T00012_A28Teoria[0] ) || ( Z29Practica != T00012_A29Practica[0] ) || ( Z30Laboratorio != T00012_A30Laboratorio[0] ) || ( StringUtil.StrCmp(Z25Observacion, T00012_A25Observacion[0]) != 0 ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z4DocenteId != T00012_A4DocenteId[0] ) || ( Z22AsignaturaId != T00012_A22AsignaturaId[0] ) || ( Z11EscuelaId != T00012_A11EscuelaId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"CargaLectivaCargaDetalle"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0115( )
      {
         BeforeValidate0115( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0115( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0115( 0) ;
            CheckOptimisticConcurrency0115( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0115( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0115( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000124 */
                     pr_default.execute(22, new Object[] {A18CargaLectivaId, A42CargaDetalleId, A27Grupo, A28Teoria, A29Practica, A30Laboratorio, A25Observacion, A4DocenteId, A22AsignaturaId, A11EscuelaId});
                     pr_default.close(22);
                     if ( (pr_default.getStatus(22) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1 ;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
            else
            {
               Load0115( ) ;
            }
            EndLevel0115( ) ;
         }
         CloseExtendedTableCursors0115( ) ;
      }

      protected void Update0115( )
      {
         BeforeValidate0115( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0115( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0115( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0115( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0115( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000125 */
                     pr_default.execute(23, new Object[] {A27Grupo, A28Teoria, A29Practica, A30Laboratorio, A25Observacion, A4DocenteId, A22AsignaturaId, A11EscuelaId, A18CargaLectivaId, A42CargaDetalleId});
                     pr_default.close(23);
                     if ( (pr_default.getStatus(23) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"CargaLectivaCargaDetalle"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0115( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0115( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                        AnyError = 1 ;
                     }
                  }
               }
            }
            EndLevel0115( ) ;
         }
         CloseExtendedTableCursors0115( ) ;
      }

      protected void DeferredUpdate0115( )
      {
      }

      protected void Delete0115( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0115( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0115( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0115( ) ;
            AfterConfirm0115( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0115( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000126 */
                  pr_default.execute(24, new Object[] {A18CargaLectivaId, A42CargaDetalleId});
                  pr_default.close(24);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp"), 1, "");
                     AnyError = 1 ;
                  }
               }
            }
         }
         sMode15 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0115( ) ;
         Gx_mode = sMode15 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0115( )
      {
         standaloneModal0115( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor T000127 */
            pr_default.execute(25, new Object[] {A4DocenteId});
            A5DocenteNombres = T000127_A5DocenteNombres[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5DocenteNombres", A5DocenteNombres);
            pr_default.close(25);
            /* Using cursor T000128 */
            pr_default.execute(26, new Object[] {A22AsignaturaId});
            A23AsignaturaNombre = T000128_A23AsignaturaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
            pr_default.close(26);
            /* Using cursor T000129 */
            pr_default.execute(27, new Object[] {A11EscuelaId});
            A12EscuelaNombre = T000129_A12EscuelaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12EscuelaNombre", A12EscuelaNombre);
            pr_default.close(27);
            A31Total = (short)(A28Teoria+A29Practica+A30Laboratorio) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31Total", StringUtil.LTrim( StringUtil.Str( (decimal)(A31Total), 4, 0)));
         }
      }

      protected void EndLevel0115( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0115( )
      {
         /* Using cursor T000130 */
         pr_default.execute(28, new Object[] {A18CargaLectivaId});
         RcdFound15 = 0 ;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound15 = 1 ;
            A42CargaDetalleId = T000130_A42CargaDetalleId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42CargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A42CargaDetalleId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0115( )
      {
         pr_default.readNext(28);
         RcdFound15 = 0 ;
         if ( (pr_default.getStatus(28) != 101) )
         {
            RcdFound15 = 1 ;
            A42CargaDetalleId = T000130_A42CargaDetalleId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42CargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A42CargaDetalleId), 4, 0)));
         }
      }

      protected void ScanEnd0115( )
      {
         pr_default.close(1);
      }

      protected void AfterConfirm0115( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0115( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0115( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0115( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0115( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0115( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0115( )
      {
         edtCargaDetalleId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargaDetalleId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargaDetalleId_Enabled), 5, 0)));
         edtDocenteId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteId_Enabled), 5, 0)));
         edtDocenteNombres_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteNombres_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteNombres_Enabled), 5, 0)));
         edtAsignaturaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)));
         edtAsignaturaNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)));
         edtEscuelaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEscuelaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEscuelaId_Enabled), 5, 0)));
         edtEscuelaNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEscuelaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEscuelaNombre_Enabled), 5, 0)));
         edtGrupo_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGrupo_Enabled), 5, 0)));
         edtTeoria_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTeoria_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTeoria_Enabled), 5, 0)));
         edtPractica_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPractica_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPractica_Enabled), 5, 0)));
         edtLaboratorio_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtLaboratorio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtLaboratorio_Enabled), 5, 0)));
         edtTotal_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTotal_Enabled), 5, 0)));
         edtObservacion_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObservacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObservacion_Enabled), 5, 0)));
      }

      protected void AddRow0115( )
      {
         nGXsfl_50_idx = (short)(nGXsfl_50_idx+1) ;
         sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
         edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_50_idx ;
         edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_50_idx ;
         imgprompt_4_Internalname = "PROMPT_4_"+sGXsfl_50_idx ;
         edtDocenteNombres_Internalname = "DOCENTENOMBRES_"+sGXsfl_50_idx ;
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_50_idx ;
         imgprompt_22_Internalname = "PROMPT_22_"+sGXsfl_50_idx ;
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_50_idx ;
         edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_50_idx ;
         imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_50_idx ;
         edtEscuelaNombre_Internalname = "ESCUELANOMBRE_"+sGXsfl_50_idx ;
         edtGrupo_Internalname = "GRUPO_"+sGXsfl_50_idx ;
         edtTeoria_Internalname = "TEORIA_"+sGXsfl_50_idx ;
         edtPractica_Internalname = "PRACTICA_"+sGXsfl_50_idx ;
         edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_50_idx ;
         edtTotal_Internalname = "TOTAL_"+sGXsfl_50_idx ;
         edtObservacion_Internalname = "OBSERVACION_"+sGXsfl_50_idx ;
         SendRow0115( ) ;
      }

      protected void SendRow0115( )
      {
         Gridcargalectiva_detalleRow = GXWebRow.GetNew(context) ;
         if ( subGridcargalectiva_detalle_Backcolorstyle == 0 )
         {
            /* None style subfile background logic. */
            subGridcargalectiva_detalle_Backstyle = 0 ;
            if ( StringUtil.StrCmp(subGridcargalectiva_detalle_Class, "") != 0 )
            {
               subGridcargalectiva_detalle_Linesclass = subGridcargalectiva_detalle_Class+"Odd" ;
            }
         }
         else if ( subGridcargalectiva_detalle_Backcolorstyle == 1 )
         {
            /* Uniform style subfile background logic. */
            subGridcargalectiva_detalle_Backstyle = 0 ;
            subGridcargalectiva_detalle_Backcolor = subGridcargalectiva_detalle_Allbackcolor ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcargalectiva_detalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcargalectiva_detalle_Backcolor), 9, 0)));
            if ( StringUtil.StrCmp(subGridcargalectiva_detalle_Class, "") != 0 )
            {
               subGridcargalectiva_detalle_Linesclass = subGridcargalectiva_detalle_Class+"Uniform" ;
            }
         }
         else if ( subGridcargalectiva_detalle_Backcolorstyle == 2 )
         {
            /* Header style subfile background logic. */
            subGridcargalectiva_detalle_Backstyle = 1 ;
            if ( StringUtil.StrCmp(subGridcargalectiva_detalle_Class, "") != 0 )
            {
               subGridcargalectiva_detalle_Linesclass = subGridcargalectiva_detalle_Class+"Odd" ;
            }
            subGridcargalectiva_detalle_Backcolor = (int)(0xF0F0F0) ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcargalectiva_detalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcargalectiva_detalle_Backcolor), 9, 0)));
         }
         else if ( subGridcargalectiva_detalle_Backcolorstyle == 3 )
         {
            /* Report style subfile background logic. */
            subGridcargalectiva_detalle_Backstyle = 1 ;
            if ( ((int)(nGXsfl_50_idx) % (2)) == 0 )
            {
               subGridcargalectiva_detalle_Backcolor = (int)(0x0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcargalectiva_detalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcargalectiva_detalle_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcargalectiva_detalle_Class, "") != 0 )
               {
                  subGridcargalectiva_detalle_Linesclass = subGridcargalectiva_detalle_Class+"Even" ;
               }
            }
            else
            {
               subGridcargalectiva_detalle_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Gridcargalectiva_detalleContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGridcargalectiva_detalle_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGridcargalectiva_detalle_Class, "") != 0 )
               {
                  subGridcargalectiva_detalle_Linesclass = subGridcargalectiva_detalle_Class+"Odd" ;
               }
            }
         }
         imgprompt_11_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx0050.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ESCUELAID_"+sGXsfl_50_idx+"'), id:'"+"ESCUELAID_"+sGXsfl_50_idx+"'"+",isOut: true}"+"],"+"gx.dom.form()."+"nIsMod_15_"+sGXsfl_50_idx+","+"'', false"+","+"false"+");") ;
         imgprompt_22_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ASIGNATURAID_"+sGXsfl_50_idx+"'), id:'"+"ASIGNATURAID_"+sGXsfl_50_idx+"'"+",isOut: true}"+"],"+"gx.dom.form()."+"nIsMod_15_"+sGXsfl_50_idx+","+"'', false"+","+"false"+");") ;
         imgprompt_4_Link = ((StringUtil.StrCmp(Gx_mode, "DSP")==0) ? "" : "javascript:"+"gx.popup.openPrompt('"+"gx00e0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"DOCENTEID_"+sGXsfl_50_idx+"'), id:'"+"DOCENTEID_"+sGXsfl_50_idx+"'"+",isOut: true}"+"],"+"gx.dom.form()."+"nIsMod_15_"+sGXsfl_50_idx+","+"'', false"+","+"false"+");") ;
         /* * Property Link not supported in */
         /* * Property Link not supported in */
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_50_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 51,'',false,'" + sGXsfl_50_idx + "',50)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCargaDetalleId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A42CargaDetalleId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A42CargaDetalleId), "ZZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(51);\"",(String)"",(String)"",(String)"",(String)"",(String)edtCargaDetalleId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtCargaDetalleId_Enabled,(short)1,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_50_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 52,'',false,'" + sGXsfl_50_idx + "',50)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDocenteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4DocenteId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A4DocenteId), "ZZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(52);\"",(String)"",(String)"",(String)"",(String)"",(String)edtDocenteId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtDocenteId_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridcargalectiva_detalleRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_4_Internalname,"prompt.gif",(String)imgprompt_4_Link,(String)"",(String)"",(String)"Modern",(int)imgprompt_4_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDocenteNombres_Internalname,StringUtil.RTrim( A5DocenteNombres),StringUtil.RTrim( context.localUtil.Format( A5DocenteNombres, "")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtDocenteNombres_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtDocenteNombres_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_50_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 54,'',false,'" + sGXsfl_50_idx + "',50)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsignaturaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22AsignaturaId), "ZZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(54);\"",(String)"",(String)"",(String)"",(String)"",(String)edtAsignaturaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtAsignaturaId_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridcargalectiva_detalleRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_22_Internalname,"prompt.gif",(String)imgprompt_22_Link,(String)"",(String)"",(String)"Modern",(int)imgprompt_22_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsignaturaNombre_Internalname,StringUtil.RTrim( A23AsignaturaNombre),StringUtil.RTrim( context.localUtil.Format( A23AsignaturaNombre, "")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtAsignaturaNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtAsignaturaNombre_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_50_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 56,'',false,'" + sGXsfl_50_idx + "',50)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEscuelaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11EscuelaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A11EscuelaId), "ZZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(56);\"",(String)"",(String)"",(String)"",(String)"",(String)edtEscuelaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtEscuelaId_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Static images/pictures */
         ClassString = "Image" ;
         StyleString = "" ;
         Gridcargalectiva_detalleRow.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)imgprompt_11_Internalname,"prompt.gif",(String)imgprompt_11_Link,(String)"",(String)"",(String)"Modern",(int)imgprompt_11_Visible,(short)1,(String)"",(String)"",(short)0,(short)0,(short)0,(String)"",(short)0,(String)"",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEscuelaNombre_Internalname,StringUtil.RTrim( A12EscuelaNombre),StringUtil.RTrim( context.localUtil.Format( A12EscuelaNombre, "")),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtEscuelaNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtEscuelaNombre_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_50_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 58,'',false,'" + sGXsfl_50_idx + "',50)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGrupo_Internalname,StringUtil.RTrim( A27Grupo),StringUtil.RTrim( context.localUtil.Format( A27Grupo, "")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(58);\"",(String)"",(String)"",(String)"",(String)"",(String)edtGrupo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtGrupo_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"left"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_50_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 59,'',false,'" + sGXsfl_50_idx + "',50)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTeoria_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A28Teoria), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A28Teoria), "ZZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(59);\"",(String)"",(String)"",(String)"",(String)"",(String)edtTeoria_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTeoria_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_50_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 60,'',false,'" + sGXsfl_50_idx + "',50)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPractica_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A29Practica), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A29Practica), "ZZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(60);\"",(String)"",(String)"",(String)"",(String)"",(String)edtPractica_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtPractica_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_50_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 61,'',false,'" + sGXsfl_50_idx + "',50)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLaboratorio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A30Laboratorio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A30Laboratorio), "ZZZ9"),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(61);\"",(String)"",(String)"",(String)"",(String)"",(String)edtLaboratorio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtLaboratorio_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTotal_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A31Total), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A31Total), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTotal_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtTotal_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"right"});
         /* Subfile cell */
         /* Single line edit */
         TempTags = " gxoch1=\"gx.fn.setControlValue('nIsMod_15_" + sGXsfl_50_idx + "',1);\"  onfocus=\"gx.evt.onfocus(this, 63,'',false,'" + sGXsfl_50_idx + "',50)\"" ;
         ClassString = "Attribute" ;
         StyleString = "" ;
         ROClassString = ClassString ;
         Gridcargalectiva_detalleRow.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtObservacion_Internalname,StringUtil.RTrim( A25Observacion),StringUtil.RTrim( context.localUtil.Format( A25Observacion, "")),TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(63);\"",(String)"",(String)"",(String)"",(String)"",(String)edtObservacion_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(int)edtObservacion_Enabled,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)100,(short)0,(short)0,(short)50,(short)1,(short)-1,(bool)true,(String)"left"});
         context.httpAjaxContext.ajax_sending_grid_row(Gridcargalectiva_detalleRow);
         GXCCtl = "Z42CargaDetalleId_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z42CargaDetalleId), 4, 0, ",", "")));
         GXCCtl = "Z27Grupo_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z27Grupo));
         GXCCtl = "Z28Teoria_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z28Teoria), 4, 0, ",", "")));
         GXCCtl = "Z29Practica_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z29Practica), 4, 0, ",", "")));
         GXCCtl = "Z30Laboratorio_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z30Laboratorio), 4, 0, ",", "")));
         GXCCtl = "Z25Observacion_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.RTrim( Z25Observacion));
         GXCCtl = "Z4DocenteId_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z4DocenteId), 4, 0, ",", "")));
         GXCCtl = "Z22AsignaturaId_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22AsignaturaId), 4, 0, ",", "")));
         GXCCtl = "Z11EscuelaId_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(Z11EscuelaId), 4, 0, ",", "")));
         GXCCtl = "nRcdDeleted_15_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdDeleted_15), 4, 0, ",", "")));
         GXCCtl = "nRcdExists_15_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nRcdExists_15), 4, 0, ",", "")));
         GXCCtl = "nIsMod_15_" + sGXsfl_50_idx ;
         GxWebStd.gx_hidden_field( context, GXCCtl, StringUtil.LTrim( StringUtil.NToC( (decimal)(nIsMod_15), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "CARGADETALLEID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtCargaDetalleId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DOCENTEID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocenteId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "DOCENTENOMBRES_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtDocenteNombres_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ASIGNATURAID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ASIGNATURANOMBRE_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtAsignaturaNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ESCUELAID_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEscuelaId_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "ESCUELANOMBRE_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtEscuelaNombre_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "GRUPO_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtGrupo_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TEORIA_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTeoria_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PRACTICA_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtPractica_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "LABORATORIO_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtLaboratorio_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "TOTAL_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtTotal_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "OBSERVACION_"+sGXsfl_50_idx+"Enabled", StringUtil.LTrim( StringUtil.NToC( (decimal)(edtObservacion_Enabled), 5, 0, ".", "")));
         GxWebStd.gx_hidden_field( context, "PROMPT_4_"+sGXsfl_50_idx+"Link", StringUtil.RTrim( imgprompt_4_Link));
         GxWebStd.gx_hidden_field( context, "PROMPT_22_"+sGXsfl_50_idx+"Link", StringUtil.RTrim( imgprompt_22_Link));
         GxWebStd.gx_hidden_field( context, "PROMPT_11_"+sGXsfl_50_idx+"Link", StringUtil.RTrim( imgprompt_11_Link));
         context.httpAjaxContext.ajax_sending_grid_row(null);
         Gridcargalectiva_detalleContainer.AddRow(Gridcargalectiva_detalleRow);
      }

      protected void ReadRow0115( )
      {
         nGXsfl_50_idx = (short)(nGXsfl_50_idx+1) ;
         sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
         edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_50_idx ;
         edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_50_idx ;
         imgprompt_4_Internalname = "PROMPT_4_"+sGXsfl_50_idx ;
         edtDocenteNombres_Internalname = "DOCENTENOMBRES_"+sGXsfl_50_idx ;
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_50_idx ;
         imgprompt_22_Internalname = "PROMPT_22_"+sGXsfl_50_idx ;
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_50_idx ;
         edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_50_idx ;
         imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_50_idx ;
         edtEscuelaNombre_Internalname = "ESCUELANOMBRE_"+sGXsfl_50_idx ;
         edtGrupo_Internalname = "GRUPO_"+sGXsfl_50_idx ;
         edtTeoria_Internalname = "TEORIA_"+sGXsfl_50_idx ;
         edtPractica_Internalname = "PRACTICA_"+sGXsfl_50_idx ;
         edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_50_idx ;
         edtTotal_Internalname = "TOTAL_"+sGXsfl_50_idx ;
         edtObservacion_Internalname = "OBSERVACION_"+sGXsfl_50_idx ;
         edtCargaDetalleId_Enabled = (int)(context.localUtil.CToN( cgiGet( "CARGADETALLEID_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargaDetalleId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargaDetalleId_Enabled), 5, 0)));
         edtDocenteId_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCENTEID_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteId_Enabled), 5, 0)));
         edtDocenteNombres_Enabled = (int)(context.localUtil.CToN( cgiGet( "DOCENTENOMBRES_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtDocenteNombres_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtDocenteNombres_Enabled), 5, 0)));
         edtAsignaturaId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURAID_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)));
         edtAsignaturaNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ASIGNATURANOMBRE_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)));
         edtEscuelaId_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESCUELAID_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEscuelaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEscuelaId_Enabled), 5, 0)));
         edtEscuelaNombre_Enabled = (int)(context.localUtil.CToN( cgiGet( "ESCUELANOMBRE_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtEscuelaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtEscuelaNombre_Enabled), 5, 0)));
         edtGrupo_Enabled = (int)(context.localUtil.CToN( cgiGet( "GRUPO_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtGrupo_Enabled), 5, 0)));
         edtTeoria_Enabled = (int)(context.localUtil.CToN( cgiGet( "TEORIA_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTeoria_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTeoria_Enabled), 5, 0)));
         edtPractica_Enabled = (int)(context.localUtil.CToN( cgiGet( "PRACTICA_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtPractica_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtPractica_Enabled), 5, 0)));
         edtLaboratorio_Enabled = (int)(context.localUtil.CToN( cgiGet( "LABORATORIO_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtLaboratorio_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtLaboratorio_Enabled), 5, 0)));
         edtTotal_Enabled = (int)(context.localUtil.CToN( cgiGet( "TOTAL_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtTotal_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtTotal_Enabled), 5, 0)));
         edtObservacion_Enabled = (int)(context.localUtil.CToN( cgiGet( "OBSERVACION_"+sGXsfl_50_idx+"Enabled"), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtObservacion_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtObservacion_Enabled), 5, 0)));
         imgprompt_4_Link = cgiGet( "PROMPT_4_"+sGXsfl_50_idx+"Link") ;
         imgprompt_4_Link = cgiGet( "PROMPT_22_"+sGXsfl_50_idx+"Link") ;
         imgprompt_4_Link = cgiGet( "PROMPT_11_"+sGXsfl_50_idx+"Link") ;
         if ( ( ( context.localUtil.CToN( cgiGet( edtCargaDetalleId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCargaDetalleId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "CARGADETALLEID");
            AnyError = 1 ;
            GX_FocusControl = edtCargaDetalleId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A42CargaDetalleId = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42CargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A42CargaDetalleId), 4, 0)));
         }
         else
         {
            A42CargaDetalleId = (short)(context.localUtil.CToN( cgiGet( edtCargaDetalleId_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42CargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A42CargaDetalleId), 4, 0)));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtDocenteId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtDocenteId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "DOCENTEID");
            AnyError = 1 ;
            GX_FocusControl = edtDocenteId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A4DocenteId = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
         }
         else
         {
            A4DocenteId = (short)(context.localUtil.CToN( cgiGet( edtDocenteId_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
         }
         A5DocenteNombres = cgiGet( edtDocenteNombres_Internalname) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5DocenteNombres", A5DocenteNombres);
         if ( ( ( context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "ASIGNATURAID");
            AnyError = 1 ;
            GX_FocusControl = edtAsignaturaId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A22AsignaturaId = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
         }
         else
         {
            A22AsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
         }
         A23AsignaturaNombre = cgiGet( edtAsignaturaNombre_Internalname) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
         if ( ( ( context.localUtil.CToN( cgiGet( edtEscuelaId_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtEscuelaId_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "ESCUELAID");
            AnyError = 1 ;
            GX_FocusControl = edtEscuelaId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A11EscuelaId = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EscuelaId), 4, 0)));
         }
         else
         {
            A11EscuelaId = (short)(context.localUtil.CToN( cgiGet( edtEscuelaId_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EscuelaId), 4, 0)));
         }
         A12EscuelaNombre = cgiGet( edtEscuelaNombre_Internalname) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12EscuelaNombre", A12EscuelaNombre);
         A27Grupo = cgiGet( edtGrupo_Internalname) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27Grupo", A27Grupo);
         if ( ( ( context.localUtil.CToN( cgiGet( edtTeoria_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtTeoria_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "TEORIA");
            AnyError = 1 ;
            GX_FocusControl = edtTeoria_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A28Teoria = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28Teoria", StringUtil.LTrim( StringUtil.Str( (decimal)(A28Teoria), 4, 0)));
         }
         else
         {
            A28Teoria = (short)(context.localUtil.CToN( cgiGet( edtTeoria_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28Teoria", StringUtil.LTrim( StringUtil.Str( (decimal)(A28Teoria), 4, 0)));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtPractica_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtPractica_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "PRACTICA");
            AnyError = 1 ;
            GX_FocusControl = edtPractica_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A29Practica = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29Practica", StringUtil.LTrim( StringUtil.Str( (decimal)(A29Practica), 4, 0)));
         }
         else
         {
            A29Practica = (short)(context.localUtil.CToN( cgiGet( edtPractica_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29Practica", StringUtil.LTrim( StringUtil.Str( (decimal)(A29Practica), 4, 0)));
         }
         if ( ( ( context.localUtil.CToN( cgiGet( edtLaboratorio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtLaboratorio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "LABORATORIO");
            AnyError = 1 ;
            GX_FocusControl = edtLaboratorio_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            wbErr = true ;
            A30Laboratorio = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30Laboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(A30Laboratorio), 4, 0)));
         }
         else
         {
            A30Laboratorio = (short)(context.localUtil.CToN( cgiGet( edtLaboratorio_Internalname), ",", ".")) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30Laboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(A30Laboratorio), 4, 0)));
         }
         A31Total = (short)(context.localUtil.CToN( cgiGet( edtTotal_Internalname), ",", ".")) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31Total", StringUtil.LTrim( StringUtil.Str( (decimal)(A31Total), 4, 0)));
         A25Observacion = cgiGet( edtObservacion_Internalname) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25Observacion", A25Observacion);
         GXCCtl = "Z42CargaDetalleId_" + sGXsfl_50_idx ;
         Z42CargaDetalleId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "Z27Grupo_" + sGXsfl_50_idx ;
         Z27Grupo = cgiGet( GXCCtl) ;
         GXCCtl = "Z28Teoria_" + sGXsfl_50_idx ;
         Z28Teoria = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "Z29Practica_" + sGXsfl_50_idx ;
         Z29Practica = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "Z30Laboratorio_" + sGXsfl_50_idx ;
         Z30Laboratorio = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "Z25Observacion_" + sGXsfl_50_idx ;
         Z25Observacion = cgiGet( GXCCtl) ;
         GXCCtl = "Z4DocenteId_" + sGXsfl_50_idx ;
         Z4DocenteId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "Z22AsignaturaId_" + sGXsfl_50_idx ;
         Z22AsignaturaId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "Z11EscuelaId_" + sGXsfl_50_idx ;
         Z11EscuelaId = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nRcdDeleted_15_" + sGXsfl_50_idx ;
         nRcdDeleted_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nRcdExists_15_" + sGXsfl_50_idx ;
         nRcdExists_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
         GXCCtl = "nIsMod_15_" + sGXsfl_50_idx ;
         nIsMod_15 = (short)(context.localUtil.CToN( cgiGet( GXCCtl), ",", ".")) ;
      }

      protected void assign_properties_default( )
      {
         defedtCargaDetalleId_Enabled = edtCargaDetalleId_Enabled ;
      }

      protected void ConfirmValues010( )
      {
         nGXsfl_50_idx = 0 ;
         sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
         edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_50_idx ;
         edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_50_idx ;
         imgprompt_4_Internalname = "PROMPT_4_"+sGXsfl_50_idx ;
         edtDocenteNombres_Internalname = "DOCENTENOMBRES_"+sGXsfl_50_idx ;
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_50_idx ;
         imgprompt_22_Internalname = "PROMPT_22_"+sGXsfl_50_idx ;
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_50_idx ;
         edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_50_idx ;
         imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_50_idx ;
         edtEscuelaNombre_Internalname = "ESCUELANOMBRE_"+sGXsfl_50_idx ;
         edtGrupo_Internalname = "GRUPO_"+sGXsfl_50_idx ;
         edtTeoria_Internalname = "TEORIA_"+sGXsfl_50_idx ;
         edtPractica_Internalname = "PRACTICA_"+sGXsfl_50_idx ;
         edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_50_idx ;
         edtTotal_Internalname = "TOTAL_"+sGXsfl_50_idx ;
         edtObservacion_Internalname = "OBSERVACION_"+sGXsfl_50_idx ;
         while ( nGXsfl_50_idx < nRC_Gridcargalectiva_detalle )
         {
            nGXsfl_50_idx = (short)(nGXsfl_50_idx+1) ;
            sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
            edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_50_idx ;
            edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_50_idx ;
            imgprompt_4_Internalname = "PROMPT_4_"+sGXsfl_50_idx ;
            edtDocenteNombres_Internalname = "DOCENTENOMBRES_"+sGXsfl_50_idx ;
            edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_50_idx ;
            imgprompt_22_Internalname = "PROMPT_22_"+sGXsfl_50_idx ;
            edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_50_idx ;
            edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_50_idx ;
            imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_50_idx ;
            edtEscuelaNombre_Internalname = "ESCUELANOMBRE_"+sGXsfl_50_idx ;
            edtGrupo_Internalname = "GRUPO_"+sGXsfl_50_idx ;
            edtTeoria_Internalname = "TEORIA_"+sGXsfl_50_idx ;
            edtPractica_Internalname = "PRACTICA_"+sGXsfl_50_idx ;
            edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_50_idx ;
            edtTotal_Internalname = "TOTAL_"+sGXsfl_50_idx ;
            edtObservacion_Internalname = "OBSERVACION_"+sGXsfl_50_idx ;
            ChangePostValue( "Z42CargaDetalleId_"+sGXsfl_50_idx, cgiGet( "ZT_"+"Z42CargaDetalleId_"+sGXsfl_50_idx)) ;
            DeletePostValue( "ZT_"+"Z42CargaDetalleId_"+sGXsfl_50_idx) ;
            ChangePostValue( "Z27Grupo_"+sGXsfl_50_idx, cgiGet( "ZT_"+"Z27Grupo_"+sGXsfl_50_idx)) ;
            DeletePostValue( "ZT_"+"Z27Grupo_"+sGXsfl_50_idx) ;
            ChangePostValue( "Z28Teoria_"+sGXsfl_50_idx, cgiGet( "ZT_"+"Z28Teoria_"+sGXsfl_50_idx)) ;
            DeletePostValue( "ZT_"+"Z28Teoria_"+sGXsfl_50_idx) ;
            ChangePostValue( "Z29Practica_"+sGXsfl_50_idx, cgiGet( "ZT_"+"Z29Practica_"+sGXsfl_50_idx)) ;
            DeletePostValue( "ZT_"+"Z29Practica_"+sGXsfl_50_idx) ;
            ChangePostValue( "Z30Laboratorio_"+sGXsfl_50_idx, cgiGet( "ZT_"+"Z30Laboratorio_"+sGXsfl_50_idx)) ;
            DeletePostValue( "ZT_"+"Z30Laboratorio_"+sGXsfl_50_idx) ;
            ChangePostValue( "Z25Observacion_"+sGXsfl_50_idx, cgiGet( "ZT_"+"Z25Observacion_"+sGXsfl_50_idx)) ;
            DeletePostValue( "ZT_"+"Z25Observacion_"+sGXsfl_50_idx) ;
            ChangePostValue( "Z4DocenteId_"+sGXsfl_50_idx, cgiGet( "ZT_"+"Z4DocenteId_"+sGXsfl_50_idx)) ;
            DeletePostValue( "ZT_"+"Z4DocenteId_"+sGXsfl_50_idx) ;
            ChangePostValue( "Z22AsignaturaId_"+sGXsfl_50_idx, cgiGet( "ZT_"+"Z22AsignaturaId_"+sGXsfl_50_idx)) ;
            DeletePostValue( "ZT_"+"Z22AsignaturaId_"+sGXsfl_50_idx) ;
            ChangePostValue( "Z11EscuelaId_"+sGXsfl_50_idx, cgiGet( "ZT_"+"Z11EscuelaId_"+sGXsfl_50_idx)) ;
            DeletePostValue( "ZT_"+"Z11EscuelaId_"+sGXsfl_50_idx) ;
         }
      }

      public override void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      public override void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( Form.Caption) ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
         MasterPageObj.master_styles();
         if ( ! context.isSmartDevice( ) )
         {
            context.AddJavascriptSource("gxgral.js", "?53786");
            context.AddJavascriptSource("gxcfg.js", "?53786");
         }
         else
         {
            context.AddJavascriptSource("gxapiSD.js", "?53786");
            context.AddJavascriptSource("gxfxSD.js", "?53786");
            context.AddJavascriptSource("gxtypesSD.js", "?53786");
            context.AddJavascriptSource("gxpopupSD.js", "?53786");
            context.AddJavascriptSource("gxfrmutlSD.js", "?53786");
            context.AddJavascriptSource("gxgridSD.js", "?53786");
            context.AddJavascriptSource("JavaScripTableSD.js", "?53786");
            context.AddJavascriptSource("rijndaelSD.js", "?53786");
            context.AddJavascriptSource("gxgralSD.js", "?53786");
            context.AddJavascriptSource("gxcfg.js", "?53786");
         }
         context.AddJavascriptSource("calendar.js", "?53786");
         context.AddJavascriptSource("calendar-setup.js", "?53786");
         context.AddJavascriptSource("calendar-es.js", "?53786");
         context.WriteHtmlText( Form.Headerrawhtml) ;
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;"+"background-color:"+context.BuildHTMLColor( Form.Backcolor)+";") ;
         if ( ! ( String.IsNullOrEmpty(StringUtil.RTrim( Form.Background)) ) )
         {
            context.WriteHtmlText( " background-image:url("+context.convertURL( Form.Background)+")") ;
         }
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("cargalectiva.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z18CargaLectivaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18CargaLectivaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z19CargaLectivaFecha", context.localUtil.DToC( Z19CargaLectivaFecha, 0, "/"));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "nRC_Gridcargalectiva_detalle", StringUtil.LTrim( StringUtil.NToC( (decimal)(nGXsfl_50_idx), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override short ExecuteStartEvent( )
      {
         standaloneStartup( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         return gxajaxcallmode ;
      }

      public override void RenderHtmlContent( )
      {
         Draw( ) ;
      }

      public override void DispatchEvents( )
      {
         Process( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "CargaLectiva" ;
      }

      public override String GetPgmdesc( )
      {
         return "Carga Lectiva " ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("cargalectiva.aspx")  ;
      }

      protected void InitializeNonKey016( )
      {
         A19CargaLectivaFecha = DateTime.MinValue ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A19CargaLectivaFecha", context.localUtil.Format(A19CargaLectivaFecha, "99/99/99"));
      }

      protected void InitAll016( )
      {
         A18CargaLectivaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
         InitializeNonKey016( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0115( )
      {
         A31Total = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A31Total", StringUtil.LTrim( StringUtil.Str( (decimal)(A31Total), 4, 0)));
         A4DocenteId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
         A5DocenteNombres = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A5DocenteNombres", A5DocenteNombres);
         A22AsignaturaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
         A23AsignaturaNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
         A11EscuelaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EscuelaId), 4, 0)));
         A12EscuelaNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A12EscuelaNombre", A12EscuelaNombre);
         A27Grupo = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27Grupo", A27Grupo);
         A28Teoria = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28Teoria", StringUtil.LTrim( StringUtil.Str( (decimal)(A28Teoria), 4, 0)));
         A29Practica = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29Practica", StringUtil.LTrim( StringUtil.Str( (decimal)(A29Practica), 4, 0)));
         A30Laboratorio = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30Laboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(A30Laboratorio), 4, 0)));
         A25Observacion = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A25Observacion", A25Observacion);
      }

      protected void InitAll0115( )
      {
         A42CargaDetalleId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42CargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A42CargaDetalleId), 4, 0)));
         InitializeNonKey0115( ) ;
      }

      protected void StandaloneModalInsert0115( )
      {
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("calendar-system.css", "?933300");
         AddThemeStyleSheetFile("", "Modern.css", "?1844366");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?8483832");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?53786");
         context.AddJavascriptSource("cargalectiva.js", "?8483832");
         /* End function include_jscripts */
      }

      protected void init_level_properties15( )
      {
         edtCargaDetalleId_Enabled = defedtCargaDetalleId_Enabled ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCargaDetalleId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCargaDetalleId_Enabled), 5, 0)));
      }

      protected void init_default_properties( )
      {
         imgBtn_first_Internalname = "BTN_FIRST" ;
         imgBtn_first_separator_Internalname = "BTN_FIRST_SEPARATOR" ;
         imgBtn_previous_Internalname = "BTN_PREVIOUS" ;
         imgBtn_previous_separator_Internalname = "BTN_PREVIOUS_SEPARATOR" ;
         imgBtn_next_Internalname = "BTN_NEXT" ;
         imgBtn_next_separator_Internalname = "BTN_NEXT_SEPARATOR" ;
         imgBtn_last_Internalname = "BTN_LAST" ;
         imgBtn_last_separator_Internalname = "BTN_LAST_SEPARATOR" ;
         imgBtn_select_Internalname = "BTN_SELECT" ;
         imgBtn_select_separator_Internalname = "BTN_SELECT_SEPARATOR" ;
         imgBtn_enter2_Internalname = "BTN_ENTER2" ;
         imgBtn_enter2_separator_Internalname = "BTN_ENTER2_SEPARATOR" ;
         imgBtn_cancel2_Internalname = "BTN_CANCEL2" ;
         imgBtn_cancel2_separator_Internalname = "BTN_CANCEL2_SEPARATOR" ;
         imgBtn_delete2_Internalname = "BTN_DELETE2" ;
         imgBtn_delete2_separator_Internalname = "BTN_DELETE2_SEPARATOR" ;
         tblTabletoolbar_Internalname = "TABLETOOLBAR" ;
         lblTextblockcargalectivaid_Internalname = "TEXTBLOCKCARGALECTIVAID" ;
         edtCargaLectivaId_Internalname = "CARGALECTIVAID" ;
         lblTextblockcargalectivafecha_Internalname = "TEXTBLOCKCARGALECTIVAFECHA" ;
         edtCargaLectivaFecha_Internalname = "CARGALECTIVAFECHA" ;
         lblTitledetalle_Internalname = "TITLEDETALLE" ;
         tblTable3_Internalname = "TABLE3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
         subGridcargalectiva_detalle_Internalname = "GRIDCARGALECTIVA_DETALLE" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Carga Lectiva " ;
         edtObservacion_Jsonclick = "" ;
         edtTotal_Jsonclick = "" ;
         edtLaboratorio_Jsonclick = "" ;
         edtPractica_Jsonclick = "" ;
         edtTeoria_Jsonclick = "" ;
         edtGrupo_Jsonclick = "" ;
         edtEscuelaNombre_Jsonclick = "" ;
         imgprompt_11_Visible = 1 ;
         imgprompt_11_Link = "" ;
         edtEscuelaId_Jsonclick = "" ;
         edtAsignaturaNombre_Jsonclick = "" ;
         imgprompt_22_Visible = 1 ;
         imgprompt_22_Link = "" ;
         edtAsignaturaId_Jsonclick = "" ;
         edtDocenteNombres_Jsonclick = "" ;
         imgprompt_4_Visible = 1 ;
         imgprompt_4_Link = "" ;
         imgprompt_4_Visible = 1 ;
         edtDocenteId_Jsonclick = "" ;
         edtCargaDetalleId_Jsonclick = "" ;
         subGridcargalectiva_detalle_Class = "Grid" ;
         imgBtn_delete2_separator_Visible = 1 ;
         imgBtn_delete2_Enabled = 1 ;
         imgBtn_delete2_Visible = 1 ;
         imgBtn_cancel2_separator_Visible = 1 ;
         imgBtn_cancel2_Visible = 1 ;
         imgBtn_enter2_separator_Visible = 1 ;
         imgBtn_enter2_Enabled = 1 ;
         imgBtn_enter2_Visible = 1 ;
         imgBtn_select_separator_Visible = 1 ;
         imgBtn_select_Visible = 1 ;
         imgBtn_last_separator_Visible = 1 ;
         imgBtn_last_Visible = 1 ;
         imgBtn_next_separator_Visible = 1 ;
         imgBtn_next_Visible = 1 ;
         imgBtn_previous_separator_Visible = 1 ;
         imgBtn_previous_Visible = 1 ;
         imgBtn_first_separator_Visible = 1 ;
         imgBtn_first_Visible = 1 ;
         edtObservacion_Enabled = 1 ;
         edtTotal_Enabled = 0 ;
         edtLaboratorio_Enabled = 1 ;
         edtPractica_Enabled = 1 ;
         edtTeoria_Enabled = 1 ;
         edtGrupo_Enabled = 1 ;
         edtEscuelaNombre_Enabled = 0 ;
         edtEscuelaId_Enabled = 1 ;
         edtAsignaturaNombre_Enabled = 0 ;
         edtAsignaturaId_Enabled = 1 ;
         edtDocenteNombres_Enabled = 0 ;
         edtDocenteId_Enabled = 1 ;
         edtCargaDetalleId_Enabled = 1 ;
         subGridcargalectiva_detalle_Backcolorstyle = 2 ;
         edtCargaLectivaFecha_Jsonclick = "" ;
         edtCargaLectivaFecha_Enabled = 1 ;
         edtCargaLectivaId_Jsonclick = "" ;
         edtCargaLectivaId_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGridcargalectiva_detalle_newrow( short nRC_Gridcargalectiva_detalle ,
                                                          short nGXsfl_50_idx ,
                                                          String sGXsfl_50_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         Gx_mode = "INS" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_50_idx ;
         edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_50_idx ;
         imgprompt_4_Internalname = "PROMPT_4_"+sGXsfl_50_idx ;
         edtDocenteNombres_Internalname = "DOCENTENOMBRES_"+sGXsfl_50_idx ;
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_50_idx ;
         imgprompt_22_Internalname = "PROMPT_22_"+sGXsfl_50_idx ;
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_50_idx ;
         edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_50_idx ;
         imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_50_idx ;
         edtEscuelaNombre_Internalname = "ESCUELANOMBRE_"+sGXsfl_50_idx ;
         edtGrupo_Internalname = "GRUPO_"+sGXsfl_50_idx ;
         edtTeoria_Internalname = "TEORIA_"+sGXsfl_50_idx ;
         edtPractica_Internalname = "PRACTICA_"+sGXsfl_50_idx ;
         edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_50_idx ;
         edtTotal_Internalname = "TOTAL_"+sGXsfl_50_idx ;
         edtObservacion_Internalname = "OBSERVACION_"+sGXsfl_50_idx ;
         while ( nGXsfl_50_idx <= nRC_Gridcargalectiva_detalle )
         {
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            standaloneNotModal0115( ) ;
            standaloneModal0115( ) ;
            dynload_actions( ) ;
            SendRow0115( ) ;
            nGXsfl_50_idx = (short)(nGXsfl_50_idx+1) ;
            sGXsfl_50_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_50_idx), 4, 0)), 4, "0") ;
            edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_50_idx ;
            edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_50_idx ;
            imgprompt_4_Internalname = "PROMPT_4_"+sGXsfl_50_idx ;
            edtDocenteNombres_Internalname = "DOCENTENOMBRES_"+sGXsfl_50_idx ;
            edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_50_idx ;
            imgprompt_22_Internalname = "PROMPT_22_"+sGXsfl_50_idx ;
            edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_50_idx ;
            edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_50_idx ;
            imgprompt_11_Internalname = "PROMPT_11_"+sGXsfl_50_idx ;
            edtEscuelaNombre_Internalname = "ESCUELANOMBRE_"+sGXsfl_50_idx ;
            edtGrupo_Internalname = "GRUPO_"+sGXsfl_50_idx ;
            edtTeoria_Internalname = "TEORIA_"+sGXsfl_50_idx ;
            edtPractica_Internalname = "PRACTICA_"+sGXsfl_50_idx ;
            edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_50_idx ;
            edtTotal_Internalname = "TOTAL_"+sGXsfl_50_idx ;
            edtObservacion_Internalname = "OBSERVACION_"+sGXsfl_50_idx ;
         }
         context.GX_webresponse.AddString(Gridcargalectiva_detalleContainer.ToJavascriptSource());
         /* End function gxnrGridcargalectiva_detalle_newrow */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtCargaLectivaFecha_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Cargalectivaid( short GX_Parm1 ,
                                        DateTime GX_Parm2 )
      {
         A18CargaLectivaId = GX_Parm1 ;
         A19CargaLectivaFecha = GX_Parm2 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(context.localUtil.Format(A19CargaLectivaFecha, "99/99/99")));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z18CargaLectivaId), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(context.localUtil.DToC( Z19CargaLectivaFecha, 0, "/")));
         isValidOutput.Add((Object)(Gridcargalectiva_detalleContainer));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Docenteid( short GX_Parm1 ,
                                   String GX_Parm2 )
      {
         A4DocenteId = GX_Parm1 ;
         A5DocenteNombres = GX_Parm2 ;
         /* Using cursor T000127 */
         pr_default.execute(25, new Object[] {A4DocenteId});
         if ( (pr_default.getStatus(25) == 101) )
         {
            AnyError4 = 1 ;
            GX_msglist.addItem("No existe 'Docente'.", "ForeignKeyNotFound", 1, "DOCENTEID");
            AnyError = 1 ;
            GX_FocusControl = edtDocenteId_Internalname ;
         }
         if ( AnyError4 == 0 )
         {
            A5DocenteNombres = T000127_A5DocenteNombres[0] ;
         }
         pr_default.close(25);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A5DocenteNombres = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A5DocenteNombres)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Asignaturaid( short GX_Parm1 ,
                                      String GX_Parm2 )
      {
         A22AsignaturaId = GX_Parm1 ;
         A23AsignaturaNombre = GX_Parm2 ;
         /* Using cursor T000128 */
         pr_default.execute(26, new Object[] {A22AsignaturaId});
         if ( (pr_default.getStatus(26) == 101) )
         {
            AnyError22 = 1 ;
            GX_msglist.addItem("No existe 'Asignatura'.", "ForeignKeyNotFound", 1, "ASIGNATURAID");
            AnyError = 1 ;
            GX_FocusControl = edtAsignaturaId_Internalname ;
         }
         if ( AnyError22 == 0 )
         {
            A23AsignaturaNombre = T000128_A23AsignaturaNombre[0] ;
         }
         pr_default.close(26);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A23AsignaturaNombre = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A23AsignaturaNombre)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      public void Valid_Escuelaid( short GX_Parm1 ,
                                   String GX_Parm2 )
      {
         A11EscuelaId = GX_Parm1 ;
         A12EscuelaNombre = GX_Parm2 ;
         /* Using cursor T000129 */
         pr_default.execute(27, new Object[] {A11EscuelaId});
         if ( (pr_default.getStatus(27) == 101) )
         {
            AnyError11 = 1 ;
            GX_msglist.addItem("No existe 'Escuela'.", "ForeignKeyNotFound", 1, "ESCUELAID");
            AnyError = 1 ;
            GX_FocusControl = edtEscuelaId_Internalname ;
         }
         if ( AnyError11 == 0 )
         {
            A12EscuelaNombre = T000129_A12EscuelaNombre[0] ;
         }
         pr_default.close(27);
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
            A12EscuelaNombre = "" ;
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A12EscuelaNombre)));
         isValidOutput.Add((Object)(context.GX_msglist.ToJavascriptSource()));
         context.GX_webresponse.AddString(isValidOutput.ToJSonString());
         wbTemp = context.ResponseContentType( "application/json") ;
      }

      protected void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(28);
         pr_default.close(25);
         pr_default.close(26);
         pr_default.close(27);
         pr_default.close(16);
         pr_default.close(10);
         pr_default.close(9);
      }

      public override void initialize( )
      {
         sPrefix = "" ;
         scmdbuf = "" ;
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         PreviousTooltip = "" ;
         PreviousCaption = "" ;
         Form = new GXWebForm();
         GX_FocusControl = "" ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         TempTags = "" ;
         bttBtn_enter_Jsonclick = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         bttBtn_delete_Jsonclick = "" ;
         lblTextblockcargalectivaid_Jsonclick = "" ;
         lblTextblockcargalectivafecha_Jsonclick = "" ;
         A19CargaLectivaFecha = DateTime.MinValue ;
         Gridcargalectiva_detalleContainer = new GXWebGrid( context);
         Gridcargalectiva_detalleColumn = new GXWebColumn();
         A5DocenteNombres = "" ;
         A23AsignaturaNombre = "" ;
         A12EscuelaNombre = "" ;
         A27Grupo = "" ;
         A25Observacion = "" ;
         Gx_mode = "" ;
         sMode15 = "" ;
         edtCargaDetalleId_Internalname = "" ;
         edtDocenteId_Internalname = "" ;
         edtDocenteNombres_Internalname = "" ;
         edtAsignaturaId_Internalname = "" ;
         edtAsignaturaNombre_Internalname = "" ;
         edtEscuelaId_Internalname = "" ;
         edtEscuelaNombre_Internalname = "" ;
         edtGrupo_Internalname = "" ;
         edtTeoria_Internalname = "" ;
         edtPractica_Internalname = "" ;
         edtLaboratorio_Internalname = "" ;
         edtTotal_Internalname = "" ;
         edtObservacion_Internalname = "" ;
         lblTitledetalle_Jsonclick = "" ;
         imgBtn_first_Jsonclick = "" ;
         imgBtn_first_separator_Jsonclick = "" ;
         imgBtn_previous_Jsonclick = "" ;
         imgBtn_previous_separator_Jsonclick = "" ;
         imgBtn_next_Jsonclick = "" ;
         imgBtn_next_separator_Jsonclick = "" ;
         imgBtn_last_Jsonclick = "" ;
         imgBtn_last_separator_Jsonclick = "" ;
         imgBtn_select_Jsonclick = "" ;
         imgBtn_select_separator_Jsonclick = "" ;
         imgBtn_enter2_Jsonclick = "" ;
         imgBtn_enter2_separator_Jsonclick = "" ;
         imgBtn_cancel2_Jsonclick = "" ;
         imgBtn_cancel2_separator_Jsonclick = "" ;
         imgBtn_delete2_Jsonclick = "" ;
         imgBtn_delete2_separator_Jsonclick = "" ;
         Z19CargaLectivaFecha = DateTime.MinValue ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Z27Grupo = "" ;
         Z25Observacion = "" ;
         T00019_A18CargaLectivaId = new short[1] ;
         T00019_A19CargaLectivaFecha = new DateTime[] {DateTime.MinValue} ;
         T000110_A18CargaLectivaId = new short[1] ;
         T00018_A18CargaLectivaId = new short[1] ;
         T00018_A19CargaLectivaFecha = new DateTime[] {DateTime.MinValue} ;
         sMode6 = "" ;
         T000111_A18CargaLectivaId = new short[1] ;
         T000112_A18CargaLectivaId = new short[1] ;
         T000113_A18CargaLectivaId = new short[1] ;
         T000113_A19CargaLectivaFecha = new DateTime[] {DateTime.MinValue} ;
         T000115_A18CargaLectivaId = new short[1] ;
         T000118_A18CargaLectivaId = new short[1] ;
         Z5DocenteNombres = "" ;
         Z23AsignaturaNombre = "" ;
         Z12EscuelaNombre = "" ;
         T000119_A18CargaLectivaId = new short[1] ;
         T000119_A42CargaDetalleId = new short[1] ;
         T000119_A5DocenteNombres = new String[] {""} ;
         T000119_A23AsignaturaNombre = new String[] {""} ;
         T000119_A12EscuelaNombre = new String[] {""} ;
         T000119_A27Grupo = new String[] {""} ;
         T000119_A28Teoria = new short[1] ;
         T000119_A29Practica = new short[1] ;
         T000119_A30Laboratorio = new short[1] ;
         T000119_A25Observacion = new String[] {""} ;
         T000119_A4DocenteId = new short[1] ;
         T000119_A22AsignaturaId = new short[1] ;
         T000119_A11EscuelaId = new short[1] ;
         T00014_A5DocenteNombres = new String[] {""} ;
         T00015_A23AsignaturaNombre = new String[] {""} ;
         T00016_A12EscuelaNombre = new String[] {""} ;
         T000120_A5DocenteNombres = new String[] {""} ;
         T000121_A23AsignaturaNombre = new String[] {""} ;
         T000122_A12EscuelaNombre = new String[] {""} ;
         T000123_A18CargaLectivaId = new short[1] ;
         T000123_A42CargaDetalleId = new short[1] ;
         T00013_A18CargaLectivaId = new short[1] ;
         T00013_A42CargaDetalleId = new short[1] ;
         T00013_A27Grupo = new String[] {""} ;
         T00013_A28Teoria = new short[1] ;
         T00013_A29Practica = new short[1] ;
         T00013_A30Laboratorio = new short[1] ;
         T00013_A25Observacion = new String[] {""} ;
         T00013_A4DocenteId = new short[1] ;
         T00013_A22AsignaturaId = new short[1] ;
         T00013_A11EscuelaId = new short[1] ;
         T00012_A18CargaLectivaId = new short[1] ;
         T00012_A42CargaDetalleId = new short[1] ;
         T00012_A27Grupo = new String[] {""} ;
         T00012_A28Teoria = new short[1] ;
         T00012_A29Practica = new short[1] ;
         T00012_A30Laboratorio = new short[1] ;
         T00012_A25Observacion = new String[] {""} ;
         T00012_A4DocenteId = new short[1] ;
         T00012_A22AsignaturaId = new short[1] ;
         T00012_A11EscuelaId = new short[1] ;
         T000127_A5DocenteNombres = new String[] {""} ;
         T000128_A23AsignaturaNombre = new String[] {""} ;
         T000129_A12EscuelaNombre = new String[] {""} ;
         T000130_A18CargaLectivaId = new short[1] ;
         T000130_A42CargaDetalleId = new short[1] ;
         imgprompt_4_Internalname = "" ;
         imgprompt_22_Internalname = "" ;
         imgprompt_11_Internalname = "" ;
         Gridcargalectiva_detalleRow = new GXWebRow();
         subGridcargalectiva_detalle_Linesclass = "" ;
         ROClassString = "" ;
         GXCCtl = "" ;
         GXt_char16 = "" ;
         GXt_char15 = "" ;
         GXt_char14 = "" ;
         GXt_char13 = "" ;
         GXt_char12 = "" ;
         GXt_char11 = "" ;
         GXt_char10 = "" ;
         GXt_char9 = "" ;
         GXt_char8 = "" ;
         GXt_char7 = "" ;
         GXt_char6 = "" ;
         GXt_char5 = "" ;
         GXt_char4 = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char17 = "" ;
         GXt_char18 = "" ;
         GXt_char19 = "" ;
         GXt_char20 = "" ;
         GXt_char21 = "" ;
         GXt_char22 = "" ;
         GXt_char23 = "" ;
         GXt_char24 = "" ;
         GXt_char25 = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char27 = "" ;
         GXt_char26 = "" ;
         GXt_char28 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cargalectiva__default(),
            new Object[][] {
                new Object[] {
               T00012_A18CargaLectivaId, T00012_A42CargaDetalleId, T00012_A27Grupo, T00012_A28Teoria, T00012_A29Practica, T00012_A30Laboratorio, T00012_A25Observacion, T00012_A4DocenteId, T00012_A22AsignaturaId, T00012_A11EscuelaId
               }
               , new Object[] {
               T00013_A18CargaLectivaId, T00013_A42CargaDetalleId, T00013_A27Grupo, T00013_A28Teoria, T00013_A29Practica, T00013_A30Laboratorio, T00013_A25Observacion, T00013_A4DocenteId, T00013_A22AsignaturaId, T00013_A11EscuelaId
               }
               , new Object[] {
               T00014_A5DocenteNombres
               }
               , new Object[] {
               T00015_A23AsignaturaNombre
               }
               , new Object[] {
               T00016_A12EscuelaNombre
               }
               , new Object[] {
               T00017_A18CargaLectivaId, T00017_A19CargaLectivaFecha
               }
               , new Object[] {
               T00018_A18CargaLectivaId, T00018_A19CargaLectivaFecha
               }
               , new Object[] {
               T00019_A18CargaLectivaId, T00019_A19CargaLectivaFecha
               }
               , new Object[] {
               T000110_A18CargaLectivaId
               }
               , new Object[] {
               T000111_A18CargaLectivaId
               }
               , new Object[] {
               T000112_A18CargaLectivaId
               }
               , new Object[] {
               T000113_A18CargaLectivaId, T000113_A19CargaLectivaFecha
               }
               , new Object[] {
               }
               , new Object[] {
               T000115_A18CargaLectivaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000118_A18CargaLectivaId
               }
               , new Object[] {
               T000119_A18CargaLectivaId, T000119_A42CargaDetalleId, T000119_A5DocenteNombres, T000119_A23AsignaturaNombre, T000119_A12EscuelaNombre, T000119_A27Grupo, T000119_A28Teoria, T000119_A29Practica, T000119_A30Laboratorio, T000119_A25Observacion,
               T000119_A4DocenteId, T000119_A22AsignaturaId, T000119_A11EscuelaId
               }
               , new Object[] {
               T000120_A5DocenteNombres
               }
               , new Object[] {
               T000121_A23AsignaturaNombre
               }
               , new Object[] {
               T000122_A12EscuelaNombre
               }
               , new Object[] {
               T000123_A18CargaLectivaId, T000123_A42CargaDetalleId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000127_A5DocenteNombres
               }
               , new Object[] {
               T000128_A23AsignaturaNombre
               }
               , new Object[] {
               T000129_A12EscuelaNombre
               }
               , new Object[] {
               T000130_A18CargaLectivaId, T000130_A42CargaDetalleId
               }
            }
         );
      }

      private short nIsMod_15 ;
      private short RcdFound6 ;
      private short GxWebError ;
      private short A4DocenteId ;
      private short A22AsignaturaId ;
      private short A11EscuelaId ;
      private short nRC_Gridcargalectiva_detalle ;
      private short nGXsfl_50_idx=1 ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A18CargaLectivaId ;
      private short subGridcargalectiva_detalle_Backcolorstyle ;
      private short A42CargaDetalleId ;
      private short A28Teoria ;
      private short A29Practica ;
      private short A30Laboratorio ;
      private short A31Total ;
      private short subGridcargalectiva_detalle_Collapsed ;
      private short nBlankRcdCount15 ;
      private short nRcdExists_15 ;
      private short RcdFound15 ;
      private short nBlankRcdUsr15 ;
      private short Z18CargaLectivaId ;
      private short nRcdDeleted_15 ;
      private short Z42CargaDetalleId ;
      private short Z28Teoria ;
      private short Z29Practica ;
      private short Z30Laboratorio ;
      private short Z4DocenteId ;
      private short Z22AsignaturaId ;
      private short Z11EscuelaId ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short subGridcargalectiva_detalle_Backstyle ;
      private short gxajaxcallmode ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtCargaLectivaId_Enabled ;
      private int edtCargaLectivaFecha_Enabled ;
      private int edtCargaDetalleId_Enabled ;
      private int edtDocenteId_Enabled ;
      private int edtDocenteNombres_Enabled ;
      private int edtAsignaturaId_Enabled ;
      private int edtAsignaturaNombre_Enabled ;
      private int edtEscuelaId_Enabled ;
      private int edtEscuelaNombre_Enabled ;
      private int edtGrupo_Enabled ;
      private int edtTeoria_Enabled ;
      private int edtPractica_Enabled ;
      private int edtLaboratorio_Enabled ;
      private int edtTotal_Enabled ;
      private int edtObservacion_Enabled ;
      private int fRowAdded ;
      private int imgBtn_first_Visible ;
      private int imgBtn_first_separator_Visible ;
      private int imgBtn_previous_Visible ;
      private int imgBtn_previous_separator_Visible ;
      private int imgBtn_next_Visible ;
      private int imgBtn_next_separator_Visible ;
      private int imgBtn_last_Visible ;
      private int imgBtn_last_separator_Visible ;
      private int imgBtn_select_Visible ;
      private int imgBtn_select_separator_Visible ;
      private int imgBtn_enter2_Visible ;
      private int imgBtn_enter2_Enabled ;
      private int imgBtn_enter2_separator_Visible ;
      private int imgBtn_cancel2_Visible ;
      private int imgBtn_cancel2_separator_Visible ;
      private int imgBtn_delete2_Visible ;
      private int imgBtn_delete2_Enabled ;
      private int imgBtn_delete2_separator_Visible ;
      private int GRIDCARGALECTIVA_DETALLE_nFirstRecordOnPage ;
      private int AnyError4 ;
      private int AnyError22 ;
      private int AnyError11 ;
      private int subGridcargalectiva_detalle_Backcolor ;
      private int subGridcargalectiva_detalle_Allbackcolor ;
      private int imgprompt_4_Visible ;
      private int imgprompt_22_Visible ;
      private int imgprompt_11_Visible ;
      private int defedtCargaDetalleId_Enabled ;
      private int idxLst ;
      private String sPrefix ;
      private String sGXsfl_50_idx="0001" ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtCargaLectivaId_Internalname ;
      private String sStyleString ;
      private String tblTablemain_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroupdata_Internalname ;
      private String tblTable1_Internalname ;
      private String TempTags ;
      private String bttBtn_enter_Internalname ;
      private String bttBtn_enter_Jsonclick ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String bttBtn_delete_Internalname ;
      private String bttBtn_delete_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockcargalectivaid_Internalname ;
      private String lblTextblockcargalectivaid_Jsonclick ;
      private String edtCargaLectivaId_Jsonclick ;
      private String lblTextblockcargalectivafecha_Internalname ;
      private String lblTextblockcargalectivafecha_Jsonclick ;
      private String edtCargaLectivaFecha_Internalname ;
      private String edtCargaLectivaFecha_Jsonclick ;
      private String Gx_mode ;
      private String sMode15 ;
      private String edtCargaDetalleId_Internalname ;
      private String edtDocenteId_Internalname ;
      private String edtDocenteNombres_Internalname ;
      private String edtAsignaturaId_Internalname ;
      private String edtAsignaturaNombre_Internalname ;
      private String edtEscuelaId_Internalname ;
      private String edtEscuelaNombre_Internalname ;
      private String edtGrupo_Internalname ;
      private String edtTeoria_Internalname ;
      private String edtPractica_Internalname ;
      private String edtLaboratorio_Internalname ;
      private String edtTotal_Internalname ;
      private String edtObservacion_Internalname ;
      private String imgprompt_4_Link ;
      private String tblTable3_Internalname ;
      private String lblTitledetalle_Internalname ;
      private String lblTitledetalle_Jsonclick ;
      private String tblTabletoolbar_Internalname ;
      private String imgBtn_first_Internalname ;
      private String imgBtn_first_Jsonclick ;
      private String imgBtn_first_separator_Internalname ;
      private String imgBtn_first_separator_Jsonclick ;
      private String imgBtn_previous_Internalname ;
      private String imgBtn_previous_Jsonclick ;
      private String imgBtn_previous_separator_Internalname ;
      private String imgBtn_previous_separator_Jsonclick ;
      private String imgBtn_next_Internalname ;
      private String imgBtn_next_Jsonclick ;
      private String imgBtn_next_separator_Internalname ;
      private String imgBtn_next_separator_Jsonclick ;
      private String imgBtn_last_Internalname ;
      private String imgBtn_last_Jsonclick ;
      private String imgBtn_last_separator_Internalname ;
      private String imgBtn_last_separator_Jsonclick ;
      private String imgBtn_select_Internalname ;
      private String imgBtn_select_Jsonclick ;
      private String imgBtn_select_separator_Internalname ;
      private String imgBtn_select_separator_Jsonclick ;
      private String imgBtn_enter2_Internalname ;
      private String imgBtn_enter2_Jsonclick ;
      private String imgBtn_enter2_separator_Internalname ;
      private String imgBtn_enter2_separator_Jsonclick ;
      private String imgBtn_cancel2_Internalname ;
      private String imgBtn_cancel2_Jsonclick ;
      private String imgBtn_cancel2_separator_Internalname ;
      private String imgBtn_cancel2_separator_Jsonclick ;
      private String imgBtn_delete2_Internalname ;
      private String imgBtn_delete2_Jsonclick ;
      private String imgBtn_delete2_separator_Internalname ;
      private String imgBtn_delete2_separator_Jsonclick ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode6 ;
      private String imgprompt_4_Internalname ;
      private String imgprompt_22_Internalname ;
      private String imgprompt_11_Internalname ;
      private String subGridcargalectiva_detalle_Class ;
      private String subGridcargalectiva_detalle_Linesclass ;
      private String imgprompt_11_Link ;
      private String imgprompt_22_Link ;
      private String ROClassString ;
      private String edtCargaDetalleId_Jsonclick ;
      private String edtDocenteId_Jsonclick ;
      private String edtDocenteNombres_Jsonclick ;
      private String edtAsignaturaId_Jsonclick ;
      private String edtAsignaturaNombre_Jsonclick ;
      private String edtEscuelaId_Jsonclick ;
      private String edtEscuelaNombre_Jsonclick ;
      private String edtGrupo_Jsonclick ;
      private String edtTeoria_Jsonclick ;
      private String edtPractica_Jsonclick ;
      private String edtLaboratorio_Jsonclick ;
      private String edtTotal_Jsonclick ;
      private String edtObservacion_Jsonclick ;
      private String GXCCtl ;
      private String GXt_char16 ;
      private String GXt_char15 ;
      private String GXt_char14 ;
      private String GXt_char13 ;
      private String GXt_char12 ;
      private String GXt_char11 ;
      private String GXt_char10 ;
      private String GXt_char9 ;
      private String GXt_char8 ;
      private String GXt_char7 ;
      private String GXt_char6 ;
      private String GXt_char5 ;
      private String GXt_char4 ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char17 ;
      private String GXt_char18 ;
      private String GXt_char19 ;
      private String GXt_char20 ;
      private String GXt_char21 ;
      private String GXt_char22 ;
      private String GXt_char23 ;
      private String GXt_char24 ;
      private String GXt_char25 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char27 ;
      private String GXt_char26 ;
      private String subGridcargalectiva_detalle_Internalname ;
      private String GXt_char28 ;
      private DateTime A19CargaLectivaFecha ;
      private DateTime Z19CargaLectivaFecha ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A5DocenteNombres ;
      private String A23AsignaturaNombre ;
      private String A12EscuelaNombre ;
      private String A27Grupo ;
      private String A25Observacion ;
      private String Z27Grupo ;
      private String Z25Observacion ;
      private String Z5DocenteNombres ;
      private String Z23AsignaturaNombre ;
      private String Z12EscuelaNombre ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Gridcargalectiva_detalleContainer ;
      private GXWebRow Gridcargalectiva_detalleRow ;
      private GXWebColumn Gridcargalectiva_detalleColumn ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00019_A18CargaLectivaId ;
      private DateTime[] T00019_A19CargaLectivaFecha ;
      private short[] T000110_A18CargaLectivaId ;
      private short[] T00018_A18CargaLectivaId ;
      private DateTime[] T00018_A19CargaLectivaFecha ;
      private short[] T000111_A18CargaLectivaId ;
      private short[] T000112_A18CargaLectivaId ;
      private short[] T000113_A18CargaLectivaId ;
      private DateTime[] T000113_A19CargaLectivaFecha ;
      private short[] T000115_A18CargaLectivaId ;
      private short[] T000118_A18CargaLectivaId ;
      private short[] T000119_A18CargaLectivaId ;
      private short[] T000119_A42CargaDetalleId ;
      private String[] T000119_A5DocenteNombres ;
      private String[] T000119_A23AsignaturaNombre ;
      private String[] T000119_A12EscuelaNombre ;
      private String[] T000119_A27Grupo ;
      private short[] T000119_A28Teoria ;
      private short[] T000119_A29Practica ;
      private short[] T000119_A30Laboratorio ;
      private String[] T000119_A25Observacion ;
      private short[] T000119_A4DocenteId ;
      private short[] T000119_A22AsignaturaId ;
      private short[] T000119_A11EscuelaId ;
      private String[] T00014_A5DocenteNombres ;
      private String[] T00015_A23AsignaturaNombre ;
      private String[] T00016_A12EscuelaNombre ;
      private String[] T000120_A5DocenteNombres ;
      private String[] T000121_A23AsignaturaNombre ;
      private String[] T000122_A12EscuelaNombre ;
      private short[] T000123_A18CargaLectivaId ;
      private short[] T000123_A42CargaDetalleId ;
      private short[] T00013_A18CargaLectivaId ;
      private short[] T00013_A42CargaDetalleId ;
      private String[] T00013_A27Grupo ;
      private short[] T00013_A28Teoria ;
      private short[] T00013_A29Practica ;
      private short[] T00013_A30Laboratorio ;
      private String[] T00013_A25Observacion ;
      private short[] T00013_A4DocenteId ;
      private short[] T00013_A22AsignaturaId ;
      private short[] T00013_A11EscuelaId ;
      private short[] T00012_A18CargaLectivaId ;
      private short[] T00012_A42CargaDetalleId ;
      private String[] T00012_A27Grupo ;
      private short[] T00012_A28Teoria ;
      private short[] T00012_A29Practica ;
      private short[] T00012_A30Laboratorio ;
      private String[] T00012_A25Observacion ;
      private short[] T00012_A4DocenteId ;
      private short[] T00012_A22AsignaturaId ;
      private short[] T00012_A11EscuelaId ;
      private String[] T000127_A5DocenteNombres ;
      private String[] T000128_A23AsignaturaNombre ;
      private String[] T000129_A12EscuelaNombre ;
      private short[] T000130_A18CargaLectivaId ;
      private short[] T000130_A42CargaDetalleId ;
      private short[] T00017_A18CargaLectivaId ;
      private DateTime[] T00017_A19CargaLectivaFecha ;
      private GXWebForm Form ;
   }

   public class cargalectiva__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new UpdateCursor(def[14])
         ,new UpdateCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new ForEachCursor(def[18])
         ,new ForEachCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
         ,new UpdateCursor(def[22])
         ,new UpdateCursor(def[23])
         ,new UpdateCursor(def[24])
         ,new ForEachCursor(def[25])
         ,new ForEachCursor(def[26])
         ,new ForEachCursor(def[27])
         ,new ForEachCursor(def[28])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00017 ;
          prmT00017 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00019 ;
          prmT00019 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000110 ;
          prmT000110 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00018 ;
          prmT00018 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000111 ;
          prmT000111 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000112 ;
          prmT000112 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000113 ;
          prmT000113 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000114 ;
          prmT000114 = new Object[] {
          new Object[] {"@CargaLectivaFecha",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmT000115 ;
          prmT000115 = new Object[] {
          } ;
          Object[] prmT000116 ;
          prmT000116 = new Object[] {
          new Object[] {"@CargaLectivaFecha",SqlDbType.DateTime,8,0} ,
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000117 ;
          prmT000117 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000118 ;
          prmT000118 = new Object[] {
          } ;
          Object[] prmT000119 ;
          prmT000119 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CargaDetalleId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00014 ;
          prmT00014 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00015 ;
          prmT00015 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00016 ;
          prmT00016 = new Object[] {
          new Object[] {"@EscuelaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000120 ;
          prmT000120 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000121 ;
          prmT000121 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000122 ;
          prmT000122 = new Object[] {
          new Object[] {"@EscuelaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000123 ;
          prmT000123 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CargaDetalleId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00013 ;
          prmT00013 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CargaDetalleId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00012 ;
          prmT00012 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CargaDetalleId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000124 ;
          prmT000124 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CargaDetalleId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Grupo",SqlDbType.VarChar,2,0} ,
          new Object[] {"@Teoria",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Practica",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Laboratorio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Observacion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EscuelaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000125 ;
          prmT000125 = new Object[] {
          new Object[] {"@Grupo",SqlDbType.VarChar,2,0} ,
          new Object[] {"@Teoria",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Practica",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Laboratorio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Observacion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@EscuelaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CargaDetalleId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000126 ;
          prmT000126 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CargaDetalleId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000130 ;
          prmT000130 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000127 ;
          prmT000127 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000128 ;
          prmT000128 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000129 ;
          prmT000129 = new Object[] {
          new Object[] {"@EscuelaId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("T00012", "SELECT [CargaLectivaId], [CargaDetalleId], [Grupo], [Teoria], [Practica], [Laboratorio], [Observacion], [DocenteId], [AsignaturaId], [EscuelaId] FROM [CargaLectivaCargaDetalle] WITH (UPDLOCK) WHERE [CargaLectivaId] = @CargaLectivaId AND [CargaDetalleId] = @CargaDetalleId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00012,1,0,true,false )
             ,new CursorDef("T00013", "SELECT [CargaLectivaId], [CargaDetalleId], [Grupo], [Teoria], [Practica], [Laboratorio], [Observacion], [DocenteId], [AsignaturaId], [EscuelaId] FROM [CargaLectivaCargaDetalle] WITH (NOLOCK) WHERE [CargaLectivaId] = @CargaLectivaId AND [CargaDetalleId] = @CargaDetalleId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00013,1,0,true,false )
             ,new CursorDef("T00014", "SELECT [DocenteNombres] FROM [Docente] WITH (NOLOCK) WHERE [DocenteId] = @DocenteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00014,1,0,true,false )
             ,new CursorDef("T00015", "SELECT [AsignaturaNombre] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00015,1,0,true,false )
             ,new CursorDef("T00016", "SELECT [EscuelaNombre] FROM [Escuela] WITH (NOLOCK) WHERE [EscuelaId] = @EscuelaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00016,1,0,true,false )
             ,new CursorDef("T00017", "SELECT [CargaLectivaId], [CargaLectivaFecha] FROM [CargaLectiva] WITH (UPDLOCK) WHERE [CargaLectivaId] = @CargaLectivaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00017,1,0,true,false )
             ,new CursorDef("T00018", "SELECT [CargaLectivaId], [CargaLectivaFecha] FROM [CargaLectiva] WITH (NOLOCK) WHERE [CargaLectivaId] = @CargaLectivaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00018,1,0,true,false )
             ,new CursorDef("T00019", "SELECT TM1.[CargaLectivaId], TM1.[CargaLectivaFecha] FROM [CargaLectiva] TM1 WITH (NOLOCK) WHERE TM1.[CargaLectivaId] = @CargaLectivaId ORDER BY TM1.[CargaLectivaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00019,100,0,true,false )
             ,new CursorDef("T000110", "SELECT [CargaLectivaId] FROM [CargaLectiva] WITH (NOLOCK) WHERE [CargaLectivaId] = @CargaLectivaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000110,1,0,true,false )
             ,new CursorDef("T000111", "SELECT TOP 1 [CargaLectivaId] FROM [CargaLectiva] WITH (NOLOCK) WHERE ( [CargaLectivaId] > @CargaLectivaId) ORDER BY [CargaLectivaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000111,1,0,true,true )
             ,new CursorDef("T000112", "SELECT TOP 1 [CargaLectivaId] FROM [CargaLectiva] WITH (NOLOCK) WHERE ( [CargaLectivaId] < @CargaLectivaId) ORDER BY [CargaLectivaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT000112,1,0,true,true )
             ,new CursorDef("T000113", "SELECT [CargaLectivaId], [CargaLectivaFecha] FROM [CargaLectiva] WITH (UPDLOCK) WHERE [CargaLectivaId] = @CargaLectivaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000113,1,0,true,false )
             ,new CursorDef("T000114", "INSERT INTO [CargaLectiva] ([CargaLectivaFecha]) VALUES (@CargaLectivaFecha)", GxErrorMask.GX_NOMASK,prmT000114)
             ,new CursorDef("T000115", "SELECT Ident_Current('[CargaLectiva]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000115,1,0,true,false )
             ,new CursorDef("T000116", "UPDATE [CargaLectiva] SET [CargaLectivaFecha]=@CargaLectivaFecha  WHERE [CargaLectivaId] = @CargaLectivaId", GxErrorMask.GX_NOMASK,prmT000116)
             ,new CursorDef("T000117", "DELETE FROM [CargaLectiva]  WHERE [CargaLectivaId] = @CargaLectivaId", GxErrorMask.GX_NOMASK,prmT000117)
             ,new CursorDef("T000118", "SELECT [CargaLectivaId] FROM [CargaLectiva] WITH (NOLOCK) ORDER BY [CargaLectivaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000118,100,0,true,false )
             ,new CursorDef("T000119", "SELECT T1.[CargaLectivaId], T1.[CargaDetalleId], T2.[DocenteNombres], T3.[AsignaturaNombre], T4.[EscuelaNombre], T1.[Grupo], T1.[Teoria], T1.[Practica], T1.[Laboratorio], T1.[Observacion], T1.[DocenteId], T1.[AsignaturaId], T1.[EscuelaId] FROM ((([CargaLectivaCargaDetalle] T1 WITH (NOLOCK) INNER JOIN [Docente] T2 WITH (NOLOCK) ON T2.[DocenteId] = T1.[DocenteId]) INNER JOIN [Asignatura] T3 WITH (NOLOCK) ON T3.[AsignaturaId] = T1.[AsignaturaId]) INNER JOIN [Escuela] T4 WITH (NOLOCK) ON T4.[EscuelaId] = T1.[EscuelaId]) WHERE T1.[CargaLectivaId] = @CargaLectivaId and T1.[CargaDetalleId] = @CargaDetalleId ORDER BY T1.[CargaLectivaId], T1.[CargaDetalleId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000119,11,0,true,false )
             ,new CursorDef("T000120", "SELECT [DocenteNombres] FROM [Docente] WITH (NOLOCK) WHERE [DocenteId] = @DocenteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000120,1,0,true,false )
             ,new CursorDef("T000121", "SELECT [AsignaturaNombre] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000121,1,0,true,false )
             ,new CursorDef("T000122", "SELECT [EscuelaNombre] FROM [Escuela] WITH (NOLOCK) WHERE [EscuelaId] = @EscuelaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000122,1,0,true,false )
             ,new CursorDef("T000123", "SELECT [CargaLectivaId], [CargaDetalleId] FROM [CargaLectivaCargaDetalle] WITH (NOLOCK) WHERE [CargaLectivaId] = @CargaLectivaId AND [CargaDetalleId] = @CargaDetalleId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000123,1,0,true,false )
             ,new CursorDef("T000124", "INSERT INTO [CargaLectivaCargaDetalle] ([CargaLectivaId], [CargaDetalleId], [Grupo], [Teoria], [Practica], [Laboratorio], [Observacion], [DocenteId], [AsignaturaId], [EscuelaId]) VALUES (@CargaLectivaId, @CargaDetalleId, @Grupo, @Teoria, @Practica, @Laboratorio, @Observacion, @DocenteId, @AsignaturaId, @EscuelaId)", GxErrorMask.GX_NOMASK,prmT000124)
             ,new CursorDef("T000125", "UPDATE [CargaLectivaCargaDetalle] SET [Grupo]=@Grupo, [Teoria]=@Teoria, [Practica]=@Practica, [Laboratorio]=@Laboratorio, [Observacion]=@Observacion, [DocenteId]=@DocenteId, [AsignaturaId]=@AsignaturaId, [EscuelaId]=@EscuelaId  WHERE [CargaLectivaId] = @CargaLectivaId AND [CargaDetalleId] = @CargaDetalleId", GxErrorMask.GX_NOMASK,prmT000125)
             ,new CursorDef("T000126", "DELETE FROM [CargaLectivaCargaDetalle]  WHERE [CargaLectivaId] = @CargaLectivaId AND [CargaDetalleId] = @CargaDetalleId", GxErrorMask.GX_NOMASK,prmT000126)
             ,new CursorDef("T000127", "SELECT [DocenteNombres] FROM [Docente] WITH (NOLOCK) WHERE [DocenteId] = @DocenteId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000127,1,0,true,false )
             ,new CursorDef("T000128", "SELECT [AsignaturaNombre] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000128,1,0,true,false )
             ,new CursorDef("T000129", "SELECT [EscuelaNombre] FROM [Escuela] WITH (NOLOCK) WHERE [EscuelaId] = @EscuelaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000129,1,0,true,false )
             ,new CursorDef("T000130", "SELECT [CargaLectivaId], [CargaDetalleId] FROM [CargaLectivaCargaDetalle] WITH (NOLOCK) WHERE [CargaLectivaId] = @CargaLectivaId ORDER BY [CargaLectivaId], [CargaDetalleId] ",true, GxErrorMask.GX_NOMASK, false, this,prmT000130,11,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getVarchar(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((short[]) buf[9])[0] = rslt.getShort(10) ;
                break;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 3 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 4 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                break;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 10 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                break;
             case 13 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getVarchar(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getVarchar(10) ;
                ((short[]) buf[10])[0] = rslt.getShort(11) ;
                ((short[]) buf[11])[0] = rslt.getShort(12) ;
                ((short[]) buf[12])[0] = rslt.getShort(13) ;
                break;
             case 18 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 19 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 20 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 25 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 26 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 27 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                break;
             case 28 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 12 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                break;
             case 14 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 22 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                break;
             case 23 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                stmt.SetParameter(8, (short)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                break;
             case 24 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 25 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 26 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 27 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 28 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
