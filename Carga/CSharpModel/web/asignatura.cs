/*
               File: Asignatura
        Description: Asignatura
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 12/3/2014 8:48:41.14
       Program type: Main program
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
   public class asignatura : GXHttpHandler, System.Web.SessionState.IRequiresSessionState
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
         Form.Meta.addItem("Description", "Asignatura", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         GX_FocusControl = edtAsignaturaId_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         wbErr = false ;
         context.SetTheme("Modern");
      }

      public asignatura( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public asignatura( IGxContext context )
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
            UserMain( ) ;
            if ( ! isFullAjaxMode( ) )
            {
               Draw( ) ;
            }
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
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            wb_table1_2_0510( true) ;
         }
         return  ;
      }

      protected void wb_table1_2_0510e( bool wbgen )
      {
         if ( wbgen )
         {
            RenderHtmlCloseForm0510( ) ;
         }
         /* Execute Exit event if defined. */
      }

      protected void wb_table1_2_0510( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTablemain_Internalname, tblTablemain_Internalname, "", "TableBorder100x100", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            wb_table2_5_0510( true) ;
         }
         return  ;
      }

      protected void wb_table2_5_0510e( bool wbgen )
      {
         if ( wbgen )
         {
            /* Control Group */
            ClassString = "Group" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroupdata_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Asignatura"+"</legend>") ;
            wb_table3_27_0510( true) ;
         }
         return  ;
      }

      protected void wb_table3_27_0510e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0510e( true) ;
         }
         else
         {
            wb_table1_2_0510e( false) ;
         }
      }

      protected void wb_table3_27_0510( bool wbgen )
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
            wb_table4_33_0510( true) ;
         }
         return  ;
      }

      protected void wb_table4_33_0510e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 71,'',false,'',0)\"" ;
            ClassString = "BtnEnter" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_enter_Internalname, "", "Confirmar", bttBtn_enter_Jsonclick, 5, "Confirmar", "", StyleString, ClassString, bttBtn_enter_Visible, 1, "rounded", "EENTER.", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 72,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, bttBtn_cancel_Visible, 1, "rounded", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 73,'',false,'',0)\"" ;
            ClassString = "BtnDelete" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_delete_Internalname, "", "Eliminar", bttBtn_delete_Jsonclick, 5, "Eliminar", "", StyleString, ClassString, bttBtn_delete_Visible, 1, "rounded", "EDELETE.", TempTags, "", context.GetButtonType( ), "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_27_0510e( true) ;
         }
         else
         {
            wb_table3_27_0510e( false) ;
         }
      }

      protected void wb_table4_33_0510( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockasignaturaid_Internalname, "Id", "", "", lblTextblockasignaturaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 38,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtAsignaturaId_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ",", "")), context.localUtil.Format( (decimal)(A22AsignaturaId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(38);\"", "", "", "", "", edtAsignaturaId_Jsonclick, 0, ClassString, StyleString, "", 1, edtAsignaturaId_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasignaturanombre_Internalname, "Nombre", "", "", lblTextblockasignaturanombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 43,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtAsignaturaNombre_Internalname, StringUtil.RTrim( A23AsignaturaNombre), StringUtil.RTrim( context.localUtil.Format( A23AsignaturaNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(43);\"", "", "", "", "", edtAsignaturaNombre_Jsonclick, 0, ClassString, StyleString, "", 1, edtAsignaturaNombre_Enabled, 0, 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, true, "left", "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcreditos_Internalname, "Creditos", "", "", lblTextblockcreditos_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34Creditos", StringUtil.LTrim( StringUtil.Str( (decimal)(A34Creditos), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 48,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtCreditos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A34Creditos), 4, 0, ",", "")), context.localUtil.Format( (decimal)(A34Creditos), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(48);\"", "", "", "", "", edtCreditos_Jsonclick, 0, ClassString, StyleString, "", 1, edtCreditos_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksemestre_Internalname, "Semestre", "", "", lblTextblocksemestre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35Semestre", StringUtil.LTrim( StringUtil.Str( (decimal)(A35Semestre), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 53,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtSemestre_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A35Semestre), 4, 0, ",", "")), context.localUtil.Format( (decimal)(A35Semestre), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(53);\"", "", "", "", "", edtSemestre_Jsonclick, 0, ClassString, StyleString, "", 1, edtSemestre_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockhorasteoria1_Internalname, "Teoria", "", "", lblTextblockhorasteoria1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39HorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(A39HorasTeoria1), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 58,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtHorasTeoria1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A39HorasTeoria1), 4, 0, ",", "")), context.localUtil.Format( (decimal)(A39HorasTeoria1), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(58);\"", "", "", "", "", edtHorasTeoria1_Jsonclick, 0, ClassString, StyleString, "", 1, edtHorasTeoria1_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockhoraspractica2_Internalname, "Practica", "", "", lblTextblockhoraspractica2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40HorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(A40HorasPractica2), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 63,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtHorasPractica2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A40HorasPractica2), 4, 0, ",", "")), context.localUtil.Format( (decimal)(A40HorasPractica2), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(63);\"", "", "", "", "", edtHorasPractica2_Jsonclick, 0, ClassString, StyleString, "", 1, edtHorasPractica2_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td valign=\"top\" class=\"td5\" >") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockhoraslaboratorio3_Internalname, "Laboratorio", "", "", lblTextblockhoraslaboratorio3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41HorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(A41HorasLaboratorio3), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 68,'',false,'',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtHorasLaboratorio3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(A41HorasLaboratorio3), 4, 0, ",", "")), context.localUtil.Format( (decimal)(A41HorasLaboratorio3), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(68);\"", "", "", "", "", edtHorasLaboratorio3_Jsonclick, 0, ClassString, StyleString, "", 1, edtHorasLaboratorio3_Enabled, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Asignatura.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_33_0510e( true) ;
         }
         else
         {
            wb_table4_33_0510e( false) ;
         }
      }

      protected void wb_table2_5_0510( bool wbgen )
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
            GxWebStd.gx_bitmap( context, imgBtn_first_Internalname, context.GetImagePath( "b9e06284-17ac-4c88-8937-5dbd84ad5d80", "", "Modern"), "", "", "", "Modern", imgBtn_first_Visible, 1, "", "Primero", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 9,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_first_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_first_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_first_separator_Jsonclick, "EFIRST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 10,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_Internalname, context.GetImagePath( "7d212604-db7b-4785-9c0d-5faffe71aa33", "", "Modern"), "", "", "", "Modern", imgBtn_previous_Visible, 1, "", "Anterior", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 11,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_previous_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_previous_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_previous_separator_Jsonclick, "EPREVIOUS.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 12,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_Internalname, context.GetImagePath( "1ae947cf-1354-41a9-8d59-d91daebf554f", "", "Modern"), "", "", "", "Modern", imgBtn_next_Visible, 1, "", "Siguiente", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 13,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_next_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_next_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_next_separator_Jsonclick, "ENEXT.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_Internalname, context.GetImagePath( "29211874-e613-48e5-9011-8017d984217e", "", "Modern"), "", "", "", "Modern", imgBtn_last_Visible, 1, "", "Ultimo", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 15,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_last_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_last_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_last_separator_Jsonclick, "ELAST.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 16,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_Internalname, context.GetImagePath( "1ca03f75-9947-4d2c-90a4-e8ab9c5cedea", "", "Modern"), "", "", "", "Modern", imgBtn_select_Visible, 1, "", "Seleccionar", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ASIGNATURAID"+"'), id:'"+"ASIGNATURAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 17,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_select_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_select_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 4, imgBtn_select_separator_Jsonclick, "ESELECT.", StyleString, ClassString, "", ""+TempTags, "", "gx.popup.openPrompt('"+"gx00a0.aspx"+"',["+"{Ctrl:gx.dom.el('"+"ASIGNATURAID"+"'), id:'"+"ASIGNATURAID"+"'"+",isOut:true,isKey:true,isLastKey:true}"+"],"+"null"+","+"'', false"+","+"true"+");"+"return false;", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 18,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_Internalname, context.GetImagePath( "2061cf2c-bd33-4433-a13e-34af954142e9", "", "Modern"), "", "", "", "Modern", imgBtn_enter2_Visible, imgBtn_enter2_Enabled, "", "Confirmar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_enter2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_enter2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_enter2_separator_Jsonclick, "EENTER.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 20,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_Internalname, context.GetImagePath( "0e94ced8-bc34-47ff-9a53-bc683736a686", "", "Modern"), "", "", "", "Modern", imgBtn_cancel2_Visible, 1, "", "Cancelar", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 21,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_cancel2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_cancel2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 1, imgBtn_cancel2_separator_Jsonclick, "ECANCEL.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 22,'',false,'',0)\"" ;
            ClassString = "ImageHandCenter" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_Internalname, context.GetImagePath( "7695fe89-52c9-4b7e-871e-0e11548f823e", "", "Modern"), "", "", "", "Modern", imgBtn_delete2_Visible, imgBtn_delete2_Enabled, "", "Eliminar", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
            /* Active images/pictures */
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 23,'',false,'',0)\"" ;
            ClassString = "ImageTop" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgBtn_delete2_separator_Internalname, context.GetImagePath( "ea7811ba-4fa2-42da-8591-e6cb10669f1f", "", "Modern"), "", "", "", "Modern", imgBtn_delete2_separator_Visible, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 5, imgBtn_delete2_separator_Jsonclick, "EDELETE.", StyleString, ClassString, "", ""+TempTags, "", "", "HLP_Asignatura.htm");
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
            wb_table2_5_0510e( true) ;
         }
         else
         {
            wb_table2_5_0510e( false) ;
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
               if ( ( ( context.localUtil.CToN( cgiGet( edtCreditos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtCreditos_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "CREDITOS");
                  AnyError = 1 ;
                  GX_FocusControl = edtCreditos_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A34Creditos = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34Creditos", StringUtil.LTrim( StringUtil.Str( (decimal)(A34Creditos), 4, 0)));
               }
               else
               {
                  A34Creditos = (short)(context.localUtil.CToN( cgiGet( edtCreditos_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34Creditos", StringUtil.LTrim( StringUtil.Str( (decimal)(A34Creditos), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtSemestre_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtSemestre_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "SEMESTRE");
                  AnyError = 1 ;
                  GX_FocusControl = edtSemestre_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A35Semestre = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35Semestre", StringUtil.LTrim( StringUtil.Str( (decimal)(A35Semestre), 4, 0)));
               }
               else
               {
                  A35Semestre = (short)(context.localUtil.CToN( cgiGet( edtSemestre_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35Semestre", StringUtil.LTrim( StringUtil.Str( (decimal)(A35Semestre), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtHorasTeoria1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtHorasTeoria1_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "HORASTEORIA1");
                  AnyError = 1 ;
                  GX_FocusControl = edtHorasTeoria1_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A39HorasTeoria1 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39HorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(A39HorasTeoria1), 4, 0)));
               }
               else
               {
                  A39HorasTeoria1 = (short)(context.localUtil.CToN( cgiGet( edtHorasTeoria1_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39HorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(A39HorasTeoria1), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtHorasPractica2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtHorasPractica2_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "HORASPRACTICA2");
                  AnyError = 1 ;
                  GX_FocusControl = edtHorasPractica2_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A40HorasPractica2 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40HorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(A40HorasPractica2), 4, 0)));
               }
               else
               {
                  A40HorasPractica2 = (short)(context.localUtil.CToN( cgiGet( edtHorasPractica2_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40HorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(A40HorasPractica2), 4, 0)));
               }
               if ( ( ( context.localUtil.CToN( cgiGet( edtHorasLaboratorio3_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtHorasLaboratorio3_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "HORASLABORATORIO3");
                  AnyError = 1 ;
                  GX_FocusControl = edtHorasLaboratorio3_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  wbErr = true ;
                  A41HorasLaboratorio3 = 0 ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41HorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(A41HorasLaboratorio3), 4, 0)));
               }
               else
               {
                  A41HorasLaboratorio3 = (short)(context.localUtil.CToN( cgiGet( edtHorasLaboratorio3_Internalname), ",", ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41HorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(A41HorasLaboratorio3), 4, 0)));
               }
               /* Read saved values. */
               Z22AsignaturaId = (short)(context.localUtil.CToN( cgiGet( "Z22AsignaturaId"), ",", ".")) ;
               Z23AsignaturaNombre = cgiGet( "Z23AsignaturaNombre") ;
               Z34Creditos = (short)(context.localUtil.CToN( cgiGet( "Z34Creditos"), ",", ".")) ;
               Z35Semestre = (short)(context.localUtil.CToN( cgiGet( "Z35Semestre"), ",", ".")) ;
               Z39HorasTeoria1 = (short)(context.localUtil.CToN( cgiGet( "Z39HorasTeoria1"), ",", ".")) ;
               Z40HorasPractica2 = (short)(context.localUtil.CToN( cgiGet( "Z40HorasPractica2"), ",", ".")) ;
               Z41HorasLaboratorio3 = (short)(context.localUtil.CToN( cgiGet( "Z41HorasLaboratorio3"), ",", ".")) ;
               IsConfirmed = (short)(context.localUtil.CToN( cgiGet( "IsConfirmed"), ",", ".")) ;
               IsModified = (short)(context.localUtil.CToN( cgiGet( "IsModified"), ",", ".")) ;
               Gx_mode = cgiGet( "Mode") ;
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
                  A22AsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
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
                  }
               }
               context.wbHandled = 1 ;
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
               InitAll0510( ) ;
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
         DisableAttributes0510( ) ;
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

      protected void ResetCaption050( )
      {
      }

      protected void ZM0510( short GX_JID )
      {
         if ( ( GX_JID == 1 ) || ( GX_JID == 0 ) )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
            {
               Z23AsignaturaNombre = T00053_A23AsignaturaNombre[0] ;
               Z34Creditos = T00053_A34Creditos[0] ;
               Z35Semestre = T00053_A35Semestre[0] ;
               Z39HorasTeoria1 = T00053_A39HorasTeoria1[0] ;
               Z40HorasPractica2 = T00053_A40HorasPractica2[0] ;
               Z41HorasLaboratorio3 = T00053_A41HorasLaboratorio3[0] ;
            }
            else
            {
               Z23AsignaturaNombre = A23AsignaturaNombre ;
               Z34Creditos = A34Creditos ;
               Z35Semestre = A35Semestre ;
               Z39HorasTeoria1 = A39HorasTeoria1 ;
               Z40HorasPractica2 = A40HorasPractica2 ;
               Z41HorasLaboratorio3 = A41HorasLaboratorio3 ;
            }
         }
         if ( GX_JID == -1 )
         {
            Z22AsignaturaId = A22AsignaturaId ;
            Z23AsignaturaNombre = A23AsignaturaNombre ;
            Z34Creditos = A34Creditos ;
            Z35Semestre = A35Semestre ;
            Z39HorasTeoria1 = A39HorasTeoria1 ;
            Z40HorasPractica2 = A40HorasPractica2 ;
            Z41HorasLaboratorio3 = A41HorasLaboratorio3 ;
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

      protected void Load0510( )
      {
         /* Using cursor T00054 */
         pr_default.execute(2, new Object[] {A22AsignaturaId});
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound10 = 1 ;
            A23AsignaturaNombre = T00054_A23AsignaturaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
            A34Creditos = T00054_A34Creditos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34Creditos", StringUtil.LTrim( StringUtil.Str( (decimal)(A34Creditos), 4, 0)));
            A35Semestre = T00054_A35Semestre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35Semestre", StringUtil.LTrim( StringUtil.Str( (decimal)(A35Semestre), 4, 0)));
            A39HorasTeoria1 = T00054_A39HorasTeoria1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39HorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(A39HorasTeoria1), 4, 0)));
            A40HorasPractica2 = T00054_A40HorasPractica2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40HorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(A40HorasPractica2), 4, 0)));
            A41HorasLaboratorio3 = T00054_A41HorasLaboratorio3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41HorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(A41HorasLaboratorio3), 4, 0)));
            ZM0510( -1) ;
         }
         pr_default.close(2);
         OnLoadActions0510( ) ;
      }

      protected void OnLoadActions0510( )
      {
      }

      protected void CheckExtendedTable0510( )
      {
         Gx_BScreen = 1 ;
         standaloneModal( ) ;
      }

      protected void CloseExtendedTableCursors0510( )
      {
      }

      protected void enableDisable( )
      {
         if ( IsConfirmed == 0 )
         {
            imgBtn_delete2_Enabled = RcdFound10 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
         else
         {
            imgBtn_delete2_Enabled = 0 ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, imgBtn_delete2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(imgBtn_delete2_Enabled), 5, 0)));
         }
      }

      protected void GetKey0510( )
      {
         /* Using cursor T00055 */
         pr_default.execute(3, new Object[] {A22AsignaturaId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound10 = 1 ;
         }
         else
         {
            RcdFound10 = 0 ;
         }
         pr_default.close(3);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor T00053 */
         pr_default.execute(1, new Object[] {A22AsignaturaId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0510( 1) ;
            RcdFound10 = 1 ;
            A22AsignaturaId = T00053_A22AsignaturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
            A23AsignaturaNombre = T00053_A23AsignaturaNombre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
            A34Creditos = T00053_A34Creditos[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34Creditos", StringUtil.LTrim( StringUtil.Str( (decimal)(A34Creditos), 4, 0)));
            A35Semestre = T00053_A35Semestre[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35Semestre", StringUtil.LTrim( StringUtil.Str( (decimal)(A35Semestre), 4, 0)));
            A39HorasTeoria1 = T00053_A39HorasTeoria1[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39HorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(A39HorasTeoria1), 4, 0)));
            A40HorasPractica2 = T00053_A40HorasPractica2[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40HorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(A40HorasPractica2), 4, 0)));
            A41HorasLaboratorio3 = T00053_A41HorasLaboratorio3[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41HorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(A41HorasLaboratorio3), 4, 0)));
            Z22AsignaturaId = A22AsignaturaId ;
            sMode10 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Load0510( ) ;
            Gx_mode = sMode10 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         else
         {
            RcdFound10 = 0 ;
            InitializeNonKey0510( ) ;
            sMode10 = Gx_mode ;
            Gx_mode = "DSP" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
            standaloneModal( ) ;
            Gx_mode = sMode10 ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0510( ) ;
         if ( RcdFound10 == 0 )
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
         RcdFound10 = 0 ;
         /* Using cursor T00056 */
         pr_default.execute(4, new Object[] {A22AsignaturaId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            while ( (pr_default.getStatus(4) != 101) && ( ( T00056_A22AsignaturaId[0] < A22AsignaturaId ) ) )
            {
               pr_default.readNext(4);
            }
            if ( (pr_default.getStatus(4) != 101) && ( ( T00056_A22AsignaturaId[0] > A22AsignaturaId ) ) )
            {
               A22AsignaturaId = T00056_A22AsignaturaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
               RcdFound10 = 1 ;
            }
         }
         pr_default.close(1);
      }

      protected void move_previous( )
      {
         RcdFound10 = 0 ;
         /* Using cursor T00057 */
         pr_default.execute(5, new Object[] {A22AsignaturaId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            while ( (pr_default.getStatus(5) != 101) && ( ( T00057_A22AsignaturaId[0] > A22AsignaturaId ) ) )
            {
               pr_default.readNext(5);
            }
            if ( (pr_default.getStatus(5) != 101) && ( ( T00057_A22AsignaturaId[0] < A22AsignaturaId ) ) )
            {
               A22AsignaturaId = T00057_A22AsignaturaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
               RcdFound10 = 1 ;
            }
         }
         pr_default.close(0);
      }

      protected void btn_enter( )
      {
         nKeyPressed = 1 ;
         GetKey0510( ) ;
         if ( RcdFound10 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate"), "DuplicatePrimaryKey", 1, "ASIGNATURAID");
               AnyError = 1 ;
               GX_FocusControl = edtAsignaturaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( A22AsignaturaId != Z22AsignaturaId )
            {
               A22AsignaturaId = Z22AsignaturaId ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd"), "CandidateKeyNotFound", 1, "ASIGNATURAID");
               AnyError = 1 ;
               GX_FocusControl = edtAsignaturaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete( ) ;
               AfterTrn( ) ;
               GX_FocusControl = edtAsignaturaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
            else
            {
               Gx_mode = "UPD" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Update record */
               Update0510( ) ;
               GX_FocusControl = edtAsignaturaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            }
         }
         else
         {
            if ( A22AsignaturaId != Z22AsignaturaId )
            {
               Gx_mode = "INS" ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
               /* Insert record */
               GX_FocusControl = edtAsignaturaId_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               Insert0510( ) ;
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
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted"), 1, "ASIGNATURAID");
                  AnyError = 1 ;
                  GX_FocusControl = edtAsignaturaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               }
               else
               {
                  Gx_mode = "INS" ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
                  /* Insert record */
                  GX_FocusControl = edtAsignaturaId_Internalname ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
                  Insert0510( ) ;
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
         if ( A22AsignaturaId != Z22AsignaturaId )
         {
            A22AsignaturaId = Z22AsignaturaId ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
            GX_msglist.addItem(context.GetMessage( "GXM_getbeforedlt"), 1, "ASIGNATURAID");
            AnyError = 1 ;
            GX_FocusControl = edtAsignaturaId_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         }
         else
         {
            delete( ) ;
            AfterTrn( ) ;
            GX_FocusControl = edtAsignaturaId_Internalname ;
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound"), "PrimaryKeyNotFound", 1, "ASIGNATURAID");
            AnyError = 1 ;
         }
         GX_FocusControl = edtAsignaturaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_first( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0510( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAsignaturaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0510( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_previous( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         move_previous( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAsignaturaNombre_Internalname ;
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
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAsignaturaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_last( )
      {
         nKeyPressed = 2 ;
         IsConfirmed = 0 ;
         ScanStart0510( ) ;
         if ( RcdFound10 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_norectobrow"), 0, "");
         }
         else
         {
            while ( RcdFound10 != 0 )
            {
               ScanNext0510( ) ;
            }
            Gx_mode = "UPD" ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         }
         GX_FocusControl = edtAsignaturaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         ScanEnd0510( ) ;
         getByPrimaryKey( ) ;
         standaloneNotModal( ) ;
         standaloneModal( ) ;
      }

      protected void btn_select( )
      {
         getEqualNoModal( ) ;
      }

      protected void CheckOptimisticConcurrency0510( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor T00058 */
            pr_default.execute(6, new Object[] {A22AsignaturaId});
            if ( (pr_default.getStatus(6) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Asignatura"}), "RecordIsLocked", 1, "");
               AnyError = 1 ;
               return  ;
            }
            Gx_longc = false ;
            if ( (pr_default.getStatus(6) == 101) || ( StringUtil.StrCmp(Z23AsignaturaNombre, T00058_A23AsignaturaNombre[0]) != 0 ) || ( Z34Creditos != T00058_A34Creditos[0] ) || ( Z35Semestre != T00058_A35Semestre[0] ) || ( Z39HorasTeoria1 != T00058_A39HorasTeoria1[0] ) || ( Z40HorasPractica2 != T00058_A40HorasPractica2[0] ) )
            {
               Gx_longc = true ;
            }
            if ( Gx_longc || ( Z41HorasLaboratorio3 != T00058_A41HorasLaboratorio3[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Asignatura"}), "RecordWasChanged", 1, "");
               AnyError = 1 ;
               return  ;
            }
         }
      }

      protected void Insert0510( )
      {
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0510( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0510( 0) ;
            CheckOptimisticConcurrency0510( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0510( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0510( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T00059 */
                     pr_default.execute(7, new Object[] {A23AsignaturaNombre, A34Creditos, A35Semestre, A39HorasTeoria1, A40HorasPractica2, A41HorasLaboratorio3});
                     pr_default.close(7);
                     /* Retrieving last key number assigned */
                     /* Using cursor T000510 */
                     pr_default.execute(8);
                     A22AsignaturaId = T000510_A22AsignaturaId[0] ;
                     context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
                     pr_default.close(8);
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded"), 0, "");
                           ResetCaption050( ) ;
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
               Load0510( ) ;
            }
            EndLevel0510( ) ;
         }
         CloseExtendedTableCursors0510( ) ;
      }

      protected void Update0510( )
      {
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0510( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0510( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0510( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0510( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor T000511 */
                     pr_default.execute(9, new Object[] {A23AsignaturaNombre, A34Creditos, A35Semestre, A39HorasTeoria1, A40HorasPractica2, A41HorasLaboratorio3, A22AsignaturaId});
                     pr_default.close(9);
                     if ( (pr_default.getStatus(9) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Asignatura"}), "RecordIsLocked", 1, "");
                        AnyError = 1 ;
                     }
                     DeferredUpdate0510( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated"), 0, "");
                           ResetCaption050( ) ;
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
            EndLevel0510( ) ;
         }
         CloseExtendedTableCursors0510( ) ;
      }

      protected void DeferredUpdate0510( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         BeforeValidate0510( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0510( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0510( ) ;
            AfterConfirm0510( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0510( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor T000512 */
                  pr_default.execute(10, new Object[] {A22AsignaturaId});
                  pr_default.close(10);
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                     if ( AnyError == 0 )
                     {
                        move_next( ) ;
                        if ( RcdFound10 == 0 )
                        {
                           InitAll0510( ) ;
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
                        ResetCaption050( ) ;
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
         sMode10 = Gx_mode ;
         Gx_mode = "DLT" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
         EndLevel0510( ) ;
         Gx_mode = sMode10 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "Gx_mode", Gx_mode);
      }

      protected void OnDeleteControls0510( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor T000513 */
            pr_default.execute(11, new Object[] {A22AsignaturaId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Carga Detalle"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1 ;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel0510( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(6);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0510( ) ;
         }
         if ( AnyError == 0 )
         {
            pr_default.close(5);
            pr_default.close(4);
            context.CommitDataStores("Asignatura");
            if ( AnyError == 0 )
            {
               ConfirmValues050( ) ;
            }
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1 ;
         }
         else
         {
            pr_default.close(5);
            pr_default.close(4);
            context.RollbackDataStores("Asignatura");
         }
         IsModified = 0 ;
         if ( AnyError != 0 )
         {
            context.wjLoc = "" ;
            context.nUserReturn = 0 ;
         }
      }

      protected void ScanStart0510( )
      {
         /* Using cursor T000514 */
         pr_default.execute(12);
         RcdFound10 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound10 = 1 ;
            A22AsignaturaId = T000514_A22AsignaturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
         }
         /* Load Subordinate Levels */
      }

      protected void ScanNext0510( )
      {
         pr_default.readNext(12);
         RcdFound10 = 0 ;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound10 = 1 ;
            A22AsignaturaId = T000514_A22AsignaturaId[0] ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
         }
      }

      protected void ScanEnd0510( )
      {
      }

      protected void AfterConfirm0510( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0510( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0510( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0510( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0510( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0510( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0510( )
      {
         edtAsignaturaId_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaId_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaId_Enabled), 5, 0)));
         edtAsignaturaNombre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtAsignaturaNombre_Enabled), 5, 0)));
         edtCreditos_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtCreditos_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtCreditos_Enabled), 5, 0)));
         edtSemestre_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtSemestre_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtSemestre_Enabled), 5, 0)));
         edtHorasTeoria1_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHorasTeoria1_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHorasTeoria1_Enabled), 5, 0)));
         edtHorasPractica2_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHorasPractica2_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHorasPractica2_Enabled), 5, 0)));
         edtHorasLaboratorio3_Enabled = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtHorasLaboratorio3_Internalname, "Enabled", StringUtil.LTrim( StringUtil.Str( (decimal)(edtHorasLaboratorio3_Enabled), 5, 0)));
      }

      protected void assign_properties_default( )
      {
      }

      protected void ConfirmValues050( )
      {
      }

      protected void RenderHtmlHeaders( )
      {
         GxWebStd.gx_html_headers( context, 0, "", "", Form.Meta, Form.Metaequiv, "IE=EmulateIE7");
      }

      protected void RenderHtmlOpenForm( )
      {
         context.WriteHtmlText( "<title>") ;
         context.WriteHtmlText( "Asignatura") ;
         context.WriteHtmlTextNl( "</title>") ;
         if ( StringUtil.Len( sDynURL) > 0 )
         {
            context.WriteHtmlText( "<BASE href=\""+sDynURL+"\" />") ;
         }
         define_styles( ) ;
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
         context.CloseHtmlHeader();
         FormProcess = " onkeyup=\"gx.evt.onkeyup(event)\" onkeypress=\"gx.evt.onkeypress(event,true,false)\" onkeydown=\"gx.evt.onkeypress(null,true,false)\"" ;
         context.WriteHtmlText( "<body") ;
         context.WriteHtmlText( " "+"class=\"Form\""+" "+" style=\"-moz-opacity:0;opacity:0;") ;
         context.WriteHtmlText( "\""+FormProcess+">") ;
         context.skipLines(1);
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("asignatura.aspx") +"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      protected void RenderHtmlCloseForm0510( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "Z22AsignaturaId", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22AsignaturaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z23AsignaturaNombre", StringUtil.RTrim( Z23AsignaturaNombre));
         GxWebStd.gx_hidden_field( context, "Z34Creditos", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34Creditos), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z35Semestre", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z35Semestre), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z39HorasTeoria1", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39HorasTeoria1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z40HorasPractica2", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40HorasPractica2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Z41HorasLaboratorio3", StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41HorasLaboratorio3), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsConfirmed", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsConfirmed), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "IsModified", StringUtil.LTrim( StringUtil.NToC( (decimal)(IsModified), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "Mode", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "vMODE", StringUtil.RTrim( Gx_mode));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
      }

      protected void InitializeNonKey0510( )
      {
         A23AsignaturaNombre = "" ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
         A34Creditos = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34Creditos", StringUtil.LTrim( StringUtil.Str( (decimal)(A34Creditos), 4, 0)));
         A35Semestre = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35Semestre", StringUtil.LTrim( StringUtil.Str( (decimal)(A35Semestre), 4, 0)));
         A39HorasTeoria1 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39HorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(A39HorasTeoria1), 4, 0)));
         A40HorasPractica2 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40HorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(A40HorasPractica2), 4, 0)));
         A41HorasLaboratorio3 = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41HorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(A41HorasLaboratorio3), 4, 0)));
      }

      protected void InitAll0510( )
      {
         A22AsignaturaId = 0 ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
         InitializeNonKey0510( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?1844366");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?848424");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?53786");
         context.AddJavascriptSource("asignatura.js", "?848424");
         /* End function include_jscripts */
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
         lblTextblockasignaturaid_Internalname = "TEXTBLOCKASIGNATURAID" ;
         edtAsignaturaId_Internalname = "ASIGNATURAID" ;
         lblTextblockasignaturanombre_Internalname = "TEXTBLOCKASIGNATURANOMBRE" ;
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE" ;
         lblTextblockcreditos_Internalname = "TEXTBLOCKCREDITOS" ;
         edtCreditos_Internalname = "CREDITOS" ;
         lblTextblocksemestre_Internalname = "TEXTBLOCKSEMESTRE" ;
         edtSemestre_Internalname = "SEMESTRE" ;
         lblTextblockhorasteoria1_Internalname = "TEXTBLOCKHORASTEORIA1" ;
         edtHorasTeoria1_Internalname = "HORASTEORIA1" ;
         lblTextblockhoraspractica2_Internalname = "TEXTBLOCKHORASPRACTICA2" ;
         edtHorasPractica2_Internalname = "HORASPRACTICA2" ;
         lblTextblockhoraslaboratorio3_Internalname = "TEXTBLOCKHORASLABORATORIO3" ;
         edtHorasLaboratorio3_Internalname = "HORASLABORATORIO3" ;
         tblTable2_Internalname = "TABLE2" ;
         bttBtn_enter_Internalname = "BTN_ENTER" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         bttBtn_delete_Internalname = "BTN_DELETE" ;
         tblTable1_Internalname = "TABLE1" ;
         grpGroupdata_Internalname = "GROUPDATA" ;
         tblTablemain_Internalname = "TABLEMAIN" ;
         Form.Internalname = "FORM" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
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
         edtHorasLaboratorio3_Jsonclick = "" ;
         edtHorasLaboratorio3_Enabled = 1 ;
         edtHorasPractica2_Jsonclick = "" ;
         edtHorasPractica2_Enabled = 1 ;
         edtHorasTeoria1_Jsonclick = "" ;
         edtHorasTeoria1_Enabled = 1 ;
         edtSemestre_Jsonclick = "" ;
         edtSemestre_Enabled = 1 ;
         edtCreditos_Jsonclick = "" ;
         edtCreditos_Enabled = 1 ;
         edtAsignaturaNombre_Jsonclick = "" ;
         edtAsignaturaNombre_Enabled = 1 ;
         edtAsignaturaId_Jsonclick = "" ;
         edtAsignaturaId_Enabled = 1 ;
         bttBtn_delete_Visible = 1 ;
         bttBtn_cancel_Visible = 1 ;
         bttBtn_enter_Visible = 1 ;
         context.GX_msglist.DisplayMode = 1 ;
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void AfterKeyLoadScreen( )
      {
         IsConfirmed = 0 ;
         getEqualNoModal( ) ;
         GX_FocusControl = edtAsignaturaNombre_Internalname ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
         standaloneNotModal( ) ;
         standaloneModal( ) ;
         /* End function AfterKeyLoadScreen */
      }

      public void Valid_Asignaturaid( short GX_Parm1 ,
                                      String GX_Parm2 ,
                                      short GX_Parm3 ,
                                      short GX_Parm4 ,
                                      short GX_Parm5 ,
                                      short GX_Parm6 ,
                                      short GX_Parm7 )
      {
         A22AsignaturaId = GX_Parm1 ;
         A23AsignaturaNombre = GX_Parm2 ;
         A34Creditos = GX_Parm3 ;
         A35Semestre = GX_Parm4 ;
         A39HorasTeoria1 = GX_Parm5 ;
         A40HorasPractica2 = GX_Parm6 ;
         A41HorasLaboratorio3 = GX_Parm7 ;
         context.wbHandled = 1 ;
         AfterKeyLoadScreen( ) ;
         Draw( ) ;
         dynload_actions( ) ;
         if ( AnyError == 1 )
         {
         }
         isValidOutput.Add((Object)(StringUtil.RTrim( A23AsignaturaNombre)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A34Creditos), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A35Semestre), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A39HorasTeoria1), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A40HorasPractica2), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(A41HorasLaboratorio3), 4, 0, ".", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Gx_mode)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z22AsignaturaId), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.RTrim( Z23AsignaturaNombre)));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z34Creditos), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z35Semestre), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z39HorasTeoria1), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z40HorasPractica2), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(StringUtil.LTrim( StringUtil.NToC( (decimal)(Z41HorasLaboratorio3), 4, 0, ",", ""))));
         isValidOutput.Add((Object)(imgBtn_enter2_Enabled));
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
         pr_default.close(12);
         pr_default.close(5);
         pr_default.close(4);
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
         lblTextblockasignaturaid_Jsonclick = "" ;
         lblTextblockasignaturanombre_Jsonclick = "" ;
         A23AsignaturaNombre = "" ;
         lblTextblockcreditos_Jsonclick = "" ;
         lblTextblocksemestre_Jsonclick = "" ;
         lblTextblockhorasteoria1_Jsonclick = "" ;
         lblTextblockhoraspractica2_Jsonclick = "" ;
         lblTextblockhoraslaboratorio3_Jsonclick = "" ;
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
         Z23AsignaturaNombre = "" ;
         Gx_mode = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         T00054_A22AsignaturaId = new short[1] ;
         T00054_A23AsignaturaNombre = new String[] {""} ;
         T00054_A34Creditos = new short[1] ;
         T00054_A35Semestre = new short[1] ;
         T00054_A39HorasTeoria1 = new short[1] ;
         T00054_A40HorasPractica2 = new short[1] ;
         T00054_A41HorasLaboratorio3 = new short[1] ;
         T00055_A22AsignaturaId = new short[1] ;
         T00053_A22AsignaturaId = new short[1] ;
         T00053_A23AsignaturaNombre = new String[] {""} ;
         T00053_A34Creditos = new short[1] ;
         T00053_A35Semestre = new short[1] ;
         T00053_A39HorasTeoria1 = new short[1] ;
         T00053_A40HorasPractica2 = new short[1] ;
         T00053_A41HorasLaboratorio3 = new short[1] ;
         sMode10 = "" ;
         T00056_A22AsignaturaId = new short[1] ;
         T00057_A22AsignaturaId = new short[1] ;
         T00058_A22AsignaturaId = new short[1] ;
         T00058_A23AsignaturaNombre = new String[] {""} ;
         T00058_A34Creditos = new short[1] ;
         T00058_A35Semestre = new short[1] ;
         T00058_A39HorasTeoria1 = new short[1] ;
         T00058_A40HorasPractica2 = new short[1] ;
         T00058_A41HorasLaboratorio3 = new short[1] ;
         T000510_A22AsignaturaId = new short[1] ;
         T000513_A18CargaLectivaId = new short[1] ;
         T000513_A42CargaDetalleId = new short[1] ;
         T000514_A22AsignaturaId = new short[1] ;
         sDynURL = "" ;
         FormProcess = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char3 = "" ;
         isValidOutput = new GxUnknownObjectCollection();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.asignatura__default(),
            new Object[][] {
                new Object[] {
               T00052_A22AsignaturaId, T00052_A23AsignaturaNombre, T00052_A34Creditos, T00052_A35Semestre, T00052_A39HorasTeoria1, T00052_A40HorasPractica2, T00052_A41HorasLaboratorio3
               }
               , new Object[] {
               T00053_A22AsignaturaId, T00053_A23AsignaturaNombre, T00053_A34Creditos, T00053_A35Semestre, T00053_A39HorasTeoria1, T00053_A40HorasPractica2, T00053_A41HorasLaboratorio3
               }
               , new Object[] {
               T00054_A22AsignaturaId, T00054_A23AsignaturaNombre, T00054_A34Creditos, T00054_A35Semestre, T00054_A39HorasTeoria1, T00054_A40HorasPractica2, T00054_A41HorasLaboratorio3
               }
               , new Object[] {
               T00055_A22AsignaturaId
               }
               , new Object[] {
               T00056_A22AsignaturaId
               }
               , new Object[] {
               T00057_A22AsignaturaId
               }
               , new Object[] {
               T00058_A22AsignaturaId, T00058_A23AsignaturaNombre, T00058_A34Creditos, T00058_A35Semestre, T00058_A39HorasTeoria1, T00058_A40HorasPractica2, T00058_A41HorasLaboratorio3
               }
               , new Object[] {
               }
               , new Object[] {
               T000510_A22AsignaturaId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               T000513_A18CargaLectivaId, T000513_A42CargaDetalleId
               }
               , new Object[] {
               T000514_A22AsignaturaId
               }
            }
         );
      }

      private short RcdFound10 ;
      private short GxWebError ;
      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short initialized ;
      private short A22AsignaturaId ;
      private short A34Creditos ;
      private short A35Semestre ;
      private short A39HorasTeoria1 ;
      private short A40HorasPractica2 ;
      private short A41HorasLaboratorio3 ;
      private short Z22AsignaturaId ;
      private short Z34Creditos ;
      private short Z35Semestre ;
      private short Z39HorasTeoria1 ;
      private short Z40HorasPractica2 ;
      private short Z41HorasLaboratorio3 ;
      private short GX_JID ;
      private short Gx_BScreen ;
      private short wbTemp ;
      private int trnEnded ;
      private int bttBtn_enter_Visible ;
      private int bttBtn_cancel_Visible ;
      private int bttBtn_delete_Visible ;
      private int edtAsignaturaId_Enabled ;
      private int edtAsignaturaNombre_Enabled ;
      private int edtCreditos_Enabled ;
      private int edtSemestre_Enabled ;
      private int edtHorasTeoria1_Enabled ;
      private int edtHorasPractica2_Enabled ;
      private int edtHorasLaboratorio3_Enabled ;
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
      private int idxLst ;
      private String sPrefix ;
      private String scmdbuf ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String GX_FocusControl ;
      private String edtAsignaturaId_Internalname ;
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
      private String lblTextblockasignaturaid_Internalname ;
      private String lblTextblockasignaturaid_Jsonclick ;
      private String edtAsignaturaId_Jsonclick ;
      private String lblTextblockasignaturanombre_Internalname ;
      private String lblTextblockasignaturanombre_Jsonclick ;
      private String edtAsignaturaNombre_Internalname ;
      private String edtAsignaturaNombre_Jsonclick ;
      private String lblTextblockcreditos_Internalname ;
      private String lblTextblockcreditos_Jsonclick ;
      private String edtCreditos_Internalname ;
      private String edtCreditos_Jsonclick ;
      private String lblTextblocksemestre_Internalname ;
      private String lblTextblocksemestre_Jsonclick ;
      private String edtSemestre_Internalname ;
      private String edtSemestre_Jsonclick ;
      private String lblTextblockhorasteoria1_Internalname ;
      private String lblTextblockhorasteoria1_Jsonclick ;
      private String edtHorasTeoria1_Internalname ;
      private String edtHorasTeoria1_Jsonclick ;
      private String lblTextblockhoraspractica2_Internalname ;
      private String lblTextblockhoraspractica2_Jsonclick ;
      private String edtHorasPractica2_Internalname ;
      private String edtHorasPractica2_Jsonclick ;
      private String lblTextblockhoraslaboratorio3_Internalname ;
      private String lblTextblockhoraslaboratorio3_Jsonclick ;
      private String edtHorasLaboratorio3_Internalname ;
      private String edtHorasLaboratorio3_Jsonclick ;
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
      private String Gx_mode ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String sMode10 ;
      private String sDynURL ;
      private String FormProcess ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char3 ;
      private bool entryPointCalled ;
      private bool wbErr ;
      private bool Gx_longc ;
      private String A23AsignaturaNombre ;
      private String Z23AsignaturaNombre ;
      private GxUnknownObjectCollection isValidOutput ;
      private GXWebForm Form ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] T00054_A22AsignaturaId ;
      private String[] T00054_A23AsignaturaNombre ;
      private short[] T00054_A34Creditos ;
      private short[] T00054_A35Semestre ;
      private short[] T00054_A39HorasTeoria1 ;
      private short[] T00054_A40HorasPractica2 ;
      private short[] T00054_A41HorasLaboratorio3 ;
      private short[] T00055_A22AsignaturaId ;
      private short[] T00053_A22AsignaturaId ;
      private String[] T00053_A23AsignaturaNombre ;
      private short[] T00053_A34Creditos ;
      private short[] T00053_A35Semestre ;
      private short[] T00053_A39HorasTeoria1 ;
      private short[] T00053_A40HorasPractica2 ;
      private short[] T00053_A41HorasLaboratorio3 ;
      private short[] T00056_A22AsignaturaId ;
      private short[] T00057_A22AsignaturaId ;
      private short[] T00058_A22AsignaturaId ;
      private String[] T00058_A23AsignaturaNombre ;
      private short[] T00058_A34Creditos ;
      private short[] T00058_A35Semestre ;
      private short[] T00058_A39HorasTeoria1 ;
      private short[] T00058_A40HorasPractica2 ;
      private short[] T00058_A41HorasLaboratorio3 ;
      private short[] T000510_A22AsignaturaId ;
      private short[] T000513_A18CargaLectivaId ;
      private short[] T000513_A42CargaDetalleId ;
      private short[] T000514_A22AsignaturaId ;
      private short[] T00052_A22AsignaturaId ;
      private String[] T00052_A23AsignaturaNombre ;
      private short[] T00052_A34Creditos ;
      private short[] T00052_A35Semestre ;
      private short[] T00052_A39HorasTeoria1 ;
      private short[] T00052_A40HorasPractica2 ;
      private short[] T00052_A41HorasLaboratorio3 ;
   }

   public class asignatura__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmT00052 ;
          prmT00052 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00054 ;
          prmT00054 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00055 ;
          prmT00055 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00053 ;
          prmT00053 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00056 ;
          prmT00056 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00057 ;
          prmT00057 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00058 ;
          prmT00058 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT00059 ;
          prmT00059 = new Object[] {
          new Object[] {"@AsignaturaNombre",SqlDbType.VarChar,60,0} ,
          new Object[] {"@Creditos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Semestre",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HorasTeoria1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HorasPractica2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HorasLaboratorio3",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000510 ;
          prmT000510 = new Object[] {
          } ;
          Object[] prmT000511 ;
          prmT000511 = new Object[] {
          new Object[] {"@AsignaturaNombre",SqlDbType.VarChar,60,0} ,
          new Object[] {"@Creditos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@Semestre",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HorasTeoria1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HorasPractica2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@HorasLaboratorio3",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000512 ;
          prmT000512 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000513 ;
          prmT000513 = new Object[] {
          new Object[] {"@AsignaturaId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmT000514 ;
          prmT000514 = new Object[] {
          } ;
          def= new CursorDef[] {
              new CursorDef("T00052", "SELECT [AsignaturaId], [AsignaturaNombre], [Creditos], [Semestre], [HorasTeoria1], [HorasPractica2], [HorasLaboratorio3] FROM [Asignatura] WITH (UPDLOCK) WHERE [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00052,1,0,true,false )
             ,new CursorDef("T00053", "SELECT [AsignaturaId], [AsignaturaNombre], [Creditos], [Semestre], [HorasTeoria1], [HorasPractica2], [HorasLaboratorio3] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00053,1,0,true,false )
             ,new CursorDef("T00054", "SELECT TM1.[AsignaturaId], TM1.[AsignaturaNombre], TM1.[Creditos], TM1.[Semestre], TM1.[HorasTeoria1], TM1.[HorasPractica2], TM1.[HorasLaboratorio3] FROM [Asignatura] TM1 WITH (NOLOCK) WHERE TM1.[AsignaturaId] = @AsignaturaId ORDER BY TM1.[AsignaturaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT00054,100,0,true,false )
             ,new CursorDef("T00055", "SELECT [AsignaturaId] FROM [Asignatura] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00055,1,0,true,false )
             ,new CursorDef("T00056", "SELECT TOP 1 [AsignaturaId] FROM [Asignatura] WITH (NOLOCK) WHERE ( [AsignaturaId] > @AsignaturaId) ORDER BY [AsignaturaId]  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00056,1,0,true,true )
             ,new CursorDef("T00057", "SELECT TOP 1 [AsignaturaId] FROM [Asignatura] WITH (NOLOCK) WHERE ( [AsignaturaId] < @AsignaturaId) ORDER BY [AsignaturaId] DESC  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmT00057,1,0,true,true )
             ,new CursorDef("T00058", "SELECT [AsignaturaId], [AsignaturaNombre], [Creditos], [Semestre], [HorasTeoria1], [HorasPractica2], [HorasLaboratorio3] FROM [Asignatura] WITH (UPDLOCK) WHERE [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT00058,1,0,true,false )
             ,new CursorDef("T00059", "INSERT INTO [Asignatura] ([AsignaturaNombre], [Creditos], [Semestre], [HorasTeoria1], [HorasPractica2], [HorasLaboratorio3]) VALUES (@AsignaturaNombre, @Creditos, @Semestre, @HorasTeoria1, @HorasPractica2, @HorasLaboratorio3)", GxErrorMask.GX_NOMASK,prmT00059)
             ,new CursorDef("T000510", "SELECT Ident_Current('[Asignatura]') ",true, GxErrorMask.GX_NOMASK, false, this,prmT000510,1,0,true,false )
             ,new CursorDef("T000511", "UPDATE [Asignatura] SET [AsignaturaNombre]=@AsignaturaNombre, [Creditos]=@Creditos, [Semestre]=@Semestre, [HorasTeoria1]=@HorasTeoria1, [HorasPractica2]=@HorasPractica2, [HorasLaboratorio3]=@HorasLaboratorio3  WHERE [AsignaturaId] = @AsignaturaId", GxErrorMask.GX_NOMASK,prmT000511)
             ,new CursorDef("T000512", "DELETE FROM [Asignatura]  WHERE [AsignaturaId] = @AsignaturaId", GxErrorMask.GX_NOMASK,prmT000512)
             ,new CursorDef("T000513", "SELECT TOP 1 [CargaLectivaId], [CargaDetalleId] FROM [CargaLectivaCargaDetalle] WITH (NOLOCK) WHERE [AsignaturaId] = @AsignaturaId ",true, GxErrorMask.GX_NOMASK, false, this,prmT000513,1,0,true,true )
             ,new CursorDef("T000514", "SELECT [AsignaturaId] FROM [Asignatura] WITH (NOLOCK) ORDER BY [AsignaturaId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmT000514,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                break;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                break;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                break;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                break;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
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
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
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
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                break;
             case 9 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                break;
       }
    }

 }

}
