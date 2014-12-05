/*
               File: Gx00F1
        Description: Selection List Carga Detalle
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 12/3/2014 8:48:47.64
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
   public class gx00f1 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00f1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00f1( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_pCargaLectivaId ,
                           out short aP1_pCargaDetalleId )
      {
         this.AV12pCargaLectivaId = aP0_pCargaLectivaId;
         this.AV13pCargaDetalleId = 0 ;
         executePrivate();
         aP1_pCargaDetalleId=this.AV13pCargaDetalleId;
      }

      void executePrivate( )
      {
         isStatic = false;
         webExecute();
      }

      protected override void createObjects( )
      {
      }

      protected void INITWEB( )
      {
         initialize_properties( ) ;
         if ( nGotPars == 0 )
         {
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
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxNewRow_"+"Grid1") == 0 )
            {
               nRC_Grid1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               nGXsfl_46_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_46_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_46_idx, sGXsfl_46_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize46 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cCargaDetalleId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cCargaDetalleId), 4, 0)));
               AV7cDocenteId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cDocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cDocenteId), 4, 0)));
               AV9cAsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cAsignaturaId), 4, 0)));
               AV10cEscuelaId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cEscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cEscuelaId), 4, 0)));
               AV11cGrupo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cGrupo", AV11cGrupo);
               AV14cTeoria = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cTeoria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cTeoria), 4, 0)));
               AV12pCargaLectivaId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pCargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pCargaLectivaId), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize46, AV6cCargaDetalleId, AV7cDocenteId, AV9cAsignaturaId, AV10cEscuelaId, AV11cGrupo, AV14cTeoria, AV12pCargaLectivaId) ;
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
            if ( ! entryPointCalled )
            {
               AV12pCargaLectivaId = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pCargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pCargaLectivaId), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV13pCargaDetalleId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pCargaDetalleId), 4, 0)));
               }
            }
         }
         context.SetTheme("Modern");
      }

      public override void webExecute( )
      {
         if ( initialized == 0 )
         {
            createObjects();
            initialize();
         }
         INITWEB( ) ;
         if ( ! isAjaxCallMode( ) )
         {
            MasterPageObj = (GXMasterPage) ClassLoader.GetInstance("promptmasterpage", "GeneXus.Programs.promptmasterpage", new Object[] {new GxContext( context.handle, context.DataStores, context.HttpContext)});
            MasterPageObj.setDataArea(this,true);
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

      public override short ExecuteStartEvent( )
      {
         PA0H2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0H2( ) ;
         }
         return gxajaxcallmode ;
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
         if ( nGXWrapped != 1 )
         {
            MasterPageObj.master_styles();
         }
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00f1.aspx") + "?" + UrlEncode("" +AV12pCargaLectivaId) + "," + UrlEncode("" +AV13pCargaDetalleId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCCARGADETALLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cCargaDetalleId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCDOCENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cDocenteId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCASIGNATURAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cAsignaturaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCESCUELAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cEscuelaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCGRUPO", StringUtil.RTrim( AV11cGrupo));
         GxWebStd.gx_hidden_field( context, "GXH_vCTEORIA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14cTeoria), 4, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPCARGALECTIVAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pCargaLectivaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPCARGADETALLEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pCargaDetalleId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nFirstRecordOnPage", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nFirstRecordOnPage), 6, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GRID1_nEOF", StringUtil.LTrim( StringUtil.NToC( (decimal)(GRID1_nEOF), 1, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GX_FocusControl", GX_FocusControl);
         SendAjaxEncryptionKey();
         SendComponentObjects();
         SendServerCommands();
         SendState();
         context.WriteHtmlTextNl( "</form>") ;
         include_jscripts( ) ;
      }

      public override void RenderHtmlContent( )
      {
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            WE0H2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0H2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00F1" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Carga Detalle" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00f1.aspx") + "?" + UrlEncode("" +AV12pCargaLectivaId) + "," + UrlEncode("" +AV13pCargaDetalleId) ;
      }

      protected void WB0H0( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            if ( nGXWrapped == 1 )
            {
               RenderHtmlHeaders( ) ;
               RenderHtmlOpenForm( ) ;
            }
            wb_table1_2_0H2( true) ;
         }
         else
         {
            wb_table1_2_0H2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0H2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0H2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_7-53786", 0) ;
         Form.Meta.addItem("Description", "Selection List Carga Detalle", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0H0( ) ;
      }

      protected void WS0H2( )
      {
         START0H2( ) ;
         EVT0H2( ) ;
      }

      protected void EVT0H2( )
      {
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) && ! wbErr )
            {
               /* Read Web Panel buttons. */
               sEvt = cgiGet( "_EventName") ;
               EvtGridId = cgiGet( "_EventGridId") ;
               EvtRowId = cgiGet( "_EventRowId") ;
               if ( StringUtil.Len( sEvt) > 0 )
               {
                  sEvtType = StringUtil.Left( sEvt, 1) ;
                  sEvt = StringUtil.Right( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                  /* Check if conditions changed and reset current page numbers */
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCARGADETALLEID"), ",", ".") != Convert.ToDecimal( AV6cCargaDetalleId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDOCENTEID"), ",", ".") != Convert.ToDecimal( AV7cDocenteId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCASIGNATURAID"), ",", ".") != Convert.ToDecimal( AV9cAsignaturaId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESCUELAID"), ",", ".") != Convert.ToDecimal( AV10cEscuelaId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPO"), AV11cGrupo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTEORIA"), ",", ".") != Convert.ToDecimal( AV14cTeoria )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(sEvtType, "M") != 0 )
                  {
                     if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                     {
                        sEvtType = StringUtil.Right( sEvt, 1) ;
                        if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                        {
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                           if ( StringUtil.StrCmp(sEvt, "RFR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                              /* No code required for Cancel button. It is implemented as the Reset button. */
                           }
                           else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                           {
                              context.wbHandled = 1 ;
                              dynload_actions( ) ;
                           }
                           else if ( StringUtil.StrCmp(sEvt, "GRID1PAGING") == 0 )
                           {
                              context.wbHandled = 1 ;
                              sEvt = cgiGet( "GRID1PAGING") ;
                              if ( StringUtil.StrCmp(sEvt, "FIRST") == 0 )
                              {
                                 subgrid1_firstpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "PREV") == 0 )
                              {
                                 subgrid1_previouspage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "NEXT") == 0 )
                              {
                                 subgrid1_nextpage( ) ;
                              }
                              else if ( StringUtil.StrCmp(sEvt, "LAST") == 0 )
                              {
                                 subgrid1_lastpage( ) ;
                              }
                           }
                        }
                        else
                        {
                           sEvtType = StringUtil.Right( sEvt, 4) ;
                           sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-4)) ;
                           if ( ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "START") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 4), "LOAD") == 0 ) || ( StringUtil.StrCmp(StringUtil.Left( sEvt, 5), "ENTER") == 0 ) )
                           {
                              nGXsfl_46_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
                              edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_46_idx ;
                              edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_46_idx ;
                              edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_46_idx ;
                              edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_46_idx ;
                              edtGrupo_Internalname = "GRUPO_"+sGXsfl_46_idx ;
                              edtTeoria_Internalname = "TEORIA_"+sGXsfl_46_idx ;
                              edtPractica_Internalname = "PRACTICA_"+sGXsfl_46_idx ;
                              edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_46_idx ;
                              edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_46_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A42CargaDetalleId = (short)(context.localUtil.CToN( cgiGet( edtCargaDetalleId_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42CargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A42CargaDetalleId), 4, 0)));
                              A4DocenteId = (short)(context.localUtil.CToN( cgiGet( edtDocenteId_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
                              A22AsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
                              A11EscuelaId = (short)(context.localUtil.CToN( cgiGet( edtEscuelaId_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EscuelaId), 4, 0)));
                              A27Grupo = cgiGet( edtGrupo_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27Grupo", A27Grupo);
                              A28Teoria = (short)(context.localUtil.CToN( cgiGet( edtTeoria_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28Teoria", StringUtil.LTrim( StringUtil.Str( (decimal)(A28Teoria), 4, 0)));
                              A29Practica = (short)(context.localUtil.CToN( cgiGet( edtPractica_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29Practica", StringUtil.LTrim( StringUtil.Str( (decimal)(A29Practica), 4, 0)));
                              A30Laboratorio = (short)(context.localUtil.CToN( cgiGet( edtLaboratorio_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30Laboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(A30Laboratorio), 4, 0)));
                              A18CargaLectivaId = (short)(context.localUtil.CToN( cgiGet( edtCargaLectivaId_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110H2 */
                                    E110H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120H2 */
                                    E120H2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Ccargadetalleid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCARGADETALLEID"), ",", ".") != Convert.ToDecimal( AV6cCargaDetalleId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cdocenteid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCDOCENTEID"), ",", ".") != Convert.ToDecimal( AV7cDocenteId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Casignaturaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCASIGNATURAID"), ",", ".") != Convert.ToDecimal( AV9cAsignaturaId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cescuelaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCESCUELAID"), ",", ".") != Convert.ToDecimal( AV10cEscuelaId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cgrupo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPO"), AV11cGrupo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cteoria Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTEORIA"), ",", ".") != Convert.ToDecimal( AV14cTeoria )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E130H2 */
                                          E130H2 ();
                                       }
                                       dynload_actions( ) ;
                                    }
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LSCR") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                 }
                              }
                              else
                              {
                              }
                           }
                        }
                     }
                     context.wbHandled = 1 ;
                  }
               }
            }
         }
      }

      protected void WE0H2( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               if ( nGXWrapped == 1 )
               {
                  RenderHtmlCloseForm( ) ;
               }
            }
         }
      }

      protected void PA0H2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCcargadetalleid_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_46_idx ,
                                       String sGXsfl_46_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_46_idx ;
         edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_46_idx ;
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_46_idx ;
         edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_46_idx ;
         edtGrupo_Internalname = "GRUPO_"+sGXsfl_46_idx ;
         edtTeoria_Internalname = "TEORIA_"+sGXsfl_46_idx ;
         edtPractica_Internalname = "PRACTICA_"+sGXsfl_46_idx ;
         edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_46_idx ;
         edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_46_idx ;
         while ( nGXsfl_46_idx <= nRC_Grid1 )
         {
            sendrow_462( ) ;
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_46_idx ;
            edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_46_idx ;
            edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_46_idx ;
            edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_46_idx ;
            edtGrupo_Internalname = "GRUPO_"+sGXsfl_46_idx ;
            edtTeoria_Internalname = "TEORIA_"+sGXsfl_46_idx ;
            edtPractica_Internalname = "PRACTICA_"+sGXsfl_46_idx ;
            edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_46_idx ;
            edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_46_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize46 ,
                                        short AV6cCargaDetalleId ,
                                        short AV7cDocenteId ,
                                        short AV9cAsignaturaId ,
                                        short AV10cEscuelaId ,
                                        String AV11cGrupo ,
                                        short AV14cTeoria ,
                                        short AV12pCargaLectivaId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize46) ;
         RF0H2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0H2( ) ;
         /* End function Refresh */
      }

      protected void RF0H2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 46 ;
         nGXsfl_46_idx = 1 ;
         sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
         edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_46_idx ;
         edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_46_idx ;
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_46_idx ;
         edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_46_idx ;
         edtGrupo_Internalname = "GRUPO_"+sGXsfl_46_idx ;
         edtTeoria_Internalname = "TEORIA_"+sGXsfl_46_idx ;
         edtPractica_Internalname = "PRACTICA_"+sGXsfl_46_idx ;
         edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_46_idx ;
         edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_46_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_46_idx ;
            edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_46_idx ;
            edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_46_idx ;
            edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_46_idx ;
            edtGrupo_Internalname = "GRUPO_"+sGXsfl_46_idx ;
            edtTeoria_Internalname = "TEORIA_"+sGXsfl_46_idx ;
            edtPractica_Internalname = "PRACTICA_"+sGXsfl_46_idx ;
            edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_46_idx ;
            edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_46_idx ;
            lV11cGrupo = StringUtil.PadR( StringUtil.RTrim( AV11cGrupo), 2, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cGrupo", AV11cGrupo);
            /* Using cursor H000H2 */
            pr_default.execute(0, new Object[] {AV12pCargaLectivaId, AV6cCargaDetalleId, AV7cDocenteId, AV9cAsignaturaId, AV10cEscuelaId, lV11cGrupo, AV14cTeoria});
            nGXsfl_46_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A18CargaLectivaId = H000H2_A18CargaLectivaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
               A30Laboratorio = H000H2_A30Laboratorio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30Laboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(A30Laboratorio), 4, 0)));
               A29Practica = H000H2_A29Practica[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29Practica", StringUtil.LTrim( StringUtil.Str( (decimal)(A29Practica), 4, 0)));
               A28Teoria = H000H2_A28Teoria[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28Teoria", StringUtil.LTrim( StringUtil.Str( (decimal)(A28Teoria), 4, 0)));
               A27Grupo = H000H2_A27Grupo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27Grupo", A27Grupo);
               A11EscuelaId = H000H2_A11EscuelaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A11EscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A11EscuelaId), 4, 0)));
               A22AsignaturaId = H000H2_A22AsignaturaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
               A4DocenteId = H000H2_A4DocenteId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
               A42CargaDetalleId = H000H2_A42CargaDetalleId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A42CargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(A42CargaDetalleId), 4, 0)));
               /* Execute user event: E120H2 */
               E120H2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 46 ;
            WB0H0( ) ;
         }
      }

      protected int subGrid1_Pagecount( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
         {
            return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))) ;
         }
         return (int)(NumberUtil.Int( (long)(GRID1_nRecordCount/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected int subGrid1_Recordcount( )
      {
         lV11cGrupo = StringUtil.PadR( StringUtil.RTrim( AV11cGrupo), 2, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cGrupo", AV11cGrupo);
         /* Using cursor H000H3 */
         pr_default.execute(1, new Object[] {AV12pCargaLectivaId, AV6cCargaDetalleId, AV7cDocenteId, AV9cAsignaturaId, AV10cEscuelaId, lV11cGrupo, AV14cTeoria});
         GRID1_nRecordCount = H000H3_AGRID1_nRecordCount[0] ;
         pr_default.close(1);
         return GRID1_nRecordCount ;
      }

      protected int subGrid1_Recordsperpage( )
      {
         if ( 10 > 0 )
         {
            if ( 1 > 0 )
            {
               return (int)(10*1) ;
            }
            else
            {
               return (int)(10) ;
            }
         }
         return (int)(-1) ;
      }

      protected int subGrid1_Currentpage( )
      {
         return (int)(NumberUtil.Int( (long)(GRID1_nFirstRecordOnPage/ (decimal)(subGrid1_Recordsperpage( ))))+1) ;
      }

      protected short subgrid1_firstpage( )
      {
         GRID1_nFirstRecordOnPage = 0 ;
         return 0 ;
      }

      protected short subgrid1_nextpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( ( GRID1_nRecordCount >= subGrid1_Recordsperpage( ) ) && ( GRID1_nEOF == 0 ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage+subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_previouspage( )
      {
         if ( GRID1_nFirstRecordOnPage >= subGrid1_Recordsperpage( ) )
         {
            GRID1_nFirstRecordOnPage = (int)(GRID1_nFirstRecordOnPage-subGrid1_Recordsperpage( )) ;
         }
         else
         {
            return 2 ;
         }
         return 0 ;
      }

      protected short subgrid1_lastpage( )
      {
         GRID1_nRecordCount = subGrid1_Recordcount( ) ;
         if ( GRID1_nRecordCount > subGrid1_Recordsperpage( ) )
         {
            if ( ((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( ))) == 0 )
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-subGrid1_Recordsperpage( )) ;
            }
            else
            {
               GRID1_nFirstRecordOnPage = (int)(GRID1_nRecordCount-((int)(GRID1_nRecordCount) % (subGrid1_Recordsperpage( )))) ;
            }
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return 0 ;
      }

      protected int subgrid1_gotopage( int nPageNo )
      {
         if ( nPageNo > 0 )
         {
            GRID1_nFirstRecordOnPage = (int)(subGrid1_Recordsperpage( )*(nPageNo-1)) ;
         }
         else
         {
            GRID1_nFirstRecordOnPage = 0 ;
         }
         return (int)(0) ;
      }

      protected void STRUP0H0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110H2 */
         E110H2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcargadetalleid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcargadetalleid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCCARGADETALLEID");
               GX_FocusControl = edtavCcargadetalleid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cCargaDetalleId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cCargaDetalleId), 4, 0)));
            }
            else
            {
               AV6cCargaDetalleId = (short)(context.localUtil.CToN( cgiGet( edtavCcargadetalleid_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cCargaDetalleId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCdocenteid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCdocenteid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCDOCENTEID");
               GX_FocusControl = edtavCdocenteid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV7cDocenteId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cDocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cDocenteId), 4, 0)));
            }
            else
            {
               AV7cDocenteId = (short)(context.localUtil.CToN( cgiGet( edtavCdocenteid_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cDocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cDocenteId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCasignaturaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCasignaturaid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCASIGNATURAID");
               GX_FocusControl = edtavCasignaturaid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cAsignaturaId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cAsignaturaId), 4, 0)));
            }
            else
            {
               AV9cAsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtavCasignaturaid_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cAsignaturaId), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCescuelaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCescuelaid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCESCUELAID");
               GX_FocusControl = edtavCescuelaid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cEscuelaId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cEscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cEscuelaId), 4, 0)));
            }
            else
            {
               AV10cEscuelaId = (short)(context.localUtil.CToN( cgiGet( edtavCescuelaid_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cEscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cEscuelaId), 4, 0)));
            }
            AV11cGrupo = cgiGet( edtavCgrupo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cGrupo", AV11cGrupo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCteoria_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCteoria_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTEORIA");
               GX_FocusControl = edtavCteoria_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14cTeoria = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cTeoria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cTeoria), 4, 0)));
            }
            else
            {
               AV14cTeoria = (short)(context.localUtil.CToN( cgiGet( edtavCteoria_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cTeoria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cTeoria), 4, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV12pCargaLectivaId = (short)(context.localUtil.CToN( cgiGet( "vPCARGALECTIVAID"), ",", ".")) ;
            AV13pCargaDetalleId = (short)(context.localUtil.CToN( cgiGet( "vPCARGADETALLEID"), ",", ".")) ;
            GRID1_nFirstRecordOnPage = (int)(context.localUtil.CToN( cgiGet( "GRID1_nFirstRecordOnPage"), ",", ".")) ;
            GRID1_nEOF = (short)(context.localUtil.CToN( cgiGet( "GRID1_nEOF"), ",", ".")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void GXStart( )
      {
         /* Execute user event: E110H2 */
         E110H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110H2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Carga Detalle", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E120H2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_462( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E130H2 */
         E130H2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130H2( )
      {
         /* Enter Routine */
         AV13pCargaDetalleId = A42CargaDetalleId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pCargaDetalleId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pCargaDetalleId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_0H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            ClassString = "ErrorViewer" ;
            StyleString = "" ;
            GxWebStd.gx_msg_list( context, "", context.GX_msglist.DisplayMode, StyleString, ClassString, "", "false");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup1_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Filters"+"</legend>") ;
            wb_table2_9_0H2( true) ;
         }
         else
         {
            wb_table2_9_0H2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_0H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Control Group */
            ClassString = "FieldSet" ;
            StyleString = "" ;
            context.WriteHtmlText( "<fieldset id=\""+grpGroup2_Internalname+"\""+" style=\"-moz-border-radius:3pt;\""+" class=\""+ClassString+"\">") ;
            context.WriteHtmlText( "<legend class=\""+ClassString+"Title"+"\">"+"Lista de Selección"+"</legend>") ;
            wb_table3_43_0H2( true) ;
         }
         else
         {
            wb_table3_43_0H2( false) ;
         }
         return  ;
      }

      protected void wb_table3_43_0H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0H2e( true) ;
         }
         else
         {
            wb_table1_2_0H2e( false) ;
         }
      }

      protected void wb_table3_43_0H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            /*  Grid Control  */
            Grid1Container.SetWrapped(nGXWrapped);
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"46\">") ;
               sStyleString = "" ;
               GxWebStd.gx_table_start( context, subGrid1_Internalname, subGrid1_Internalname, "", "Grid", 0, "", "", 1, 0, sStyleString, "", 0);
               /* Subfile titles */
               context.WriteHtmlText( "<tr") ;
               context.WriteHtmlTextNl( ">") ;
               if ( subGrid1_Backcolorstyle == 0 )
               {
                  subGrid1_Titlebackstyle = 0 ;
                  if ( StringUtil.Len( subGrid1_Class) > 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Title" ;
                  }
               }
               else
               {
                  subGrid1_Titlebackstyle = 1 ;
                  if ( subGrid1_Backcolorstyle == 1 )
                  {
                     subGrid1_Titlebackcolor = subGrid1_Allbackcolor ;
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"UniformTitle" ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.Len( subGrid1_Class) > 0 )
                     {
                        subGrid1_Linesclass = subGrid1_Class+"Title" ;
                     }
                  }
               }
               context.WriteHtmlText( "<th align=\""+""+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Detalle Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Docente Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "A") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "E") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"left"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Grupo") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Teoria") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Practica") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Laboratorio") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( " Id") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlTextNl( "</tr>") ;
               Grid1Container.AddObjectProperty("GridName", "Grid1");
            }
            else
            {
               if ( isAjaxCallMode( ) )
               {
                  Grid1Container = new GXWebGrid( context);
               }
               else
               {
                  Grid1Container.Clear();
               }
               Grid1Container.SetWrapped(nGXWrapped);
               Grid1Container.AddObjectProperty("GridName", "Grid1");
               Grid1Container.AddObjectProperty("Class", "Grid");
               Grid1Container.AddObjectProperty("Cellpadding", StringUtil.LTrim( StringUtil.NToC( (decimal)(1), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Cellspacing", StringUtil.LTrim( StringUtil.NToC( (decimal)(0), 4, 0, ".", "")));
               Grid1Container.AddObjectProperty("Backcolorstyle", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Backcolorstyle), 1, 0, ".", "")));
               Grid1Container.AddObjectProperty("CmpContext", "");
               Grid1Container.AddObjectProperty("InMasterPage", "false");
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", context.convertURL( AV5LinkSelection));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtavLinkselection_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A42CargaDetalleId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4DocenteId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A11EscuelaId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A27Grupo));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtGrupo_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A28Teoria), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A29Practica), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A30Laboratorio), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A18CargaLectivaId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 46 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_46_idx-1) ;
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "</table>") ;
               context.WriteHtmlText( "</div>") ;
            }
            else
            {
               Grid1Container.AddObjectProperty("GRID1_nEOF", GRID1_nEOF);
               Grid1Container.AddObjectProperty("GRID1_nFirstRecordOnPage", GRID1_nFirstRecordOnPage);
               sStyleString = " style=\"display:none;\"" ;
               sStyleString = "" ;
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"Div\" "+sStyleString+">"+"</div>") ;
               context.httpAjaxContext.ajax_rsp_assign_grid("_"+"Grid1", (Object)(Grid1Container));
               GxWebStd.gx_hidden_field( context, "Grid1ContainerData", Grid1Container.ToJavascriptSource());
               if ( context.isAjaxRequest( ) )
               {
                  GxWebStd.gx_hidden_field( context, "Grid1ContainerData"+"V", Grid1Container.GridValuesHidden());
               }
               else
               {
                  context.WriteHtmlText( "<input type=\"hidden\" "+"name=\""+"Grid1ContainerData"+"V"+"\" value='"+Grid1Container.GridValuesHidden()+"'>") ;
               }
            }
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            wb_table4_59_0H2( true) ;
         }
         else
         {
            wb_table4_59_0H2( false) ;
         }
         return  ;
      }

      protected void wb_table4_59_0H2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_43_0H2e( true) ;
         }
         else
         {
            wb_table3_43_0H2e( false) ;
         }
      }

      protected void wb_table4_59_0H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 62,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(46), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_59_0H2e( true) ;
         }
         else
         {
            wb_table4_59_0H2e( false) ;
         }
      }

      protected void wb_table2_9_0H2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcargadetalleid_Internalname, "Carga Detalle Id", "", "", lblTextblockcargadetalleid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cCargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cCargaDetalleId), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcargadetalleid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cCargaDetalleId), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV6cCargaDetalleId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", "", "", "", "", edtavCcargadetalleid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockdocenteid_Internalname, "Docente Id", "", "", lblTextblockdocenteid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cDocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV7cDocenteId), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCdocenteid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV7cDocenteId), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV7cDocenteId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(19);\"", "", "", "", "", edtavCdocenteid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasignaturaid_Internalname, "Asignatura Id", "", "", lblTextblockasignaturaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cAsignaturaId), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasignaturaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cAsignaturaId), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV9cAsignaturaId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCasignaturaid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockescuelaid_Internalname, "Escuela Id", "", "", lblTextblockescuelaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cEscuelaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cEscuelaId), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCescuelaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cEscuelaId), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV10cEscuelaId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCescuelaid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_Internalname, "Grupo", "", "", lblTextblockgrupo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11cGrupo", AV11cGrupo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgrupo_Internalname, StringUtil.RTrim( AV11cGrupo), StringUtil.RTrim( context.localUtil.Format( AV11cGrupo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(34);\"", "", "", "", "", edtavCgrupo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockteoria_Internalname, "Teoria", "", "", lblTextblockteoria_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cTeoria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cTeoria), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_46_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCteoria_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14cTeoria), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV14cTeoria), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(39);\"", "", "", "", "", edtavCteoria_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00F1.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_0H2e( true) ;
         }
         else
         {
            wb_table2_9_0H2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV12pCargaLectivaId = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pCargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pCargaLectivaId), 4, 0)));
         AV13pCargaDetalleId = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pCargaDetalleId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pCargaDetalleId), 4, 0)));
      }

      public override String getresponse( String sGXDynURL )
      {
         initialize_properties( ) ;
         BackMsgLst = context.GX_msglist ;
         context.GX_msglist = LclMsgLst ;
         sDynURL = sGXDynURL ;
         nGotPars = (short)(1) ;
         nGXWrapped = (short)(1) ;
         context.SetWrapped(true);
         PA0H2( ) ;
         WS0H2( ) ;
         WE0H2( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      protected void define_styles( )
      {
         AddThemeStyleSheetFile("", "Modern.css", "?1844366");
         idxLst = 1 ;
         while ( idxLst <= Form.Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?8484819");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?53786");
         context.AddJavascriptSource("gx00f1.js", "?8484820");
         /* End function include_jscripts */
      }

      protected void sendrow_462( )
      {
         WB0H0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_46_idx <= subGrid1_Recordsperpage( ) * 1 ) )
         {
            Grid1Row = GXWebRow.GetNew(context,Grid1Container) ;
            if ( subGrid1_Backcolorstyle == 0 )
            {
               /* None style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 1 )
            {
               /* Uniform style subfile background logic. */
               subGrid1_Backstyle = 0 ;
               subGrid1_Backcolor = subGrid1_Allbackcolor ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Uniform" ;
               }
            }
            else if ( subGrid1_Backcolorstyle == 2 )
            {
               /* Header style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
               {
                  subGrid1_Linesclass = subGrid1_Class+"Odd" ;
               }
               subGrid1_Backcolor = (int)(0xF0F0F0) ;
               context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
            }
            else if ( subGrid1_Backcolorstyle == 3 )
            {
               /* Report style subfile background logic. */
               subGrid1_Backstyle = 1 ;
               if ( ((int)(nGXsfl_46_idx) % (2)) == 0 )
               {
                  subGrid1_Backcolor = (int)(0x0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Even" ;
                  }
               }
               else
               {
                  subGrid1_Backcolor = (int)(0xF0F0F0) ;
                  context.httpAjaxContext.ajax_rsp_assign_prop("", false, "Grid1ContainerDiv", "Backcolor", StringUtil.LTrim( StringUtil.Str( (decimal)(subGrid1_Backcolor), 9, 0)));
                  if ( StringUtil.StrCmp(subGrid1_Class, "") != 0 )
                  {
                     subGrid1_Linesclass = subGrid1_Class+"Odd" ;
                  }
               }
            }
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<tr ") ;
               context.WriteHtmlText( " class=\""+subGrid1_Linesclass+"\" style=\""+""+"\"") ;
               context.WriteHtmlText( " gxrow=\""+sGXsfl_46_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A42CargaDetalleId), 4, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Link", edtavLinkselection_Link);
            ClassString = "Image" ;
            StyleString = "" ;
            Grid1Row.AddColumnProperties("bitmap", 1, isAjaxCallMode( ), new Object[] {(String)edtavLinkselection_Internalname,(String)AV5LinkSelection,(String)edtavLinkselection_Link,(String)"",(String)"",(String)"Modern",(short)-1,(short)1,(String)"",(String)"Seleccionar",(short)0,(short)-1,(short)0,(String)"px",(short)0,(String)"px",(short)0,(short)0,(short)0,(String)"",(String)"",(String)StyleString,(String)ClassString,(String)"",(String)"",(String)"''",(String)""});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCargaDetalleId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A42CargaDetalleId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A42CargaDetalleId), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCargaDetalleId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDocenteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4DocenteId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A4DocenteId), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtDocenteId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsignaturaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22AsignaturaId), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtAsignaturaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtEscuelaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A11EscuelaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A11EscuelaId), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtEscuelaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtGrupo_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A42CargaDetalleId), 4, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Internalname, "Link", edtGrupo_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGrupo_Internalname,StringUtil.RTrim( A27Grupo),StringUtil.RTrim( context.localUtil.Format( A27Grupo, "")),(String)"",(String)"",(String)edtGrupo_Link,(String)"",(String)"Seleccionar",(String)edtGrupo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTeoria_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A28Teoria), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A28Teoria), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTeoria_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPractica_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A29Practica), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A29Practica), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPractica_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLaboratorio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A30Laboratorio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A30Laboratorio), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtLaboratorio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCargaLectivaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A18CargaLectivaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A18CargaLectivaId), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCargaLectivaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)46,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_46_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_46_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_46_idx+1)) ;
            sGXsfl_46_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_46_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_46_idx ;
            edtCargaDetalleId_Internalname = "CARGADETALLEID_"+sGXsfl_46_idx ;
            edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_46_idx ;
            edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_46_idx ;
            edtEscuelaId_Internalname = "ESCUELAID_"+sGXsfl_46_idx ;
            edtGrupo_Internalname = "GRUPO_"+sGXsfl_46_idx ;
            edtTeoria_Internalname = "TEORIA_"+sGXsfl_46_idx ;
            edtPractica_Internalname = "PRACTICA_"+sGXsfl_46_idx ;
            edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_46_idx ;
            edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_46_idx ;
         }
         /* End function sendrow_462 */
      }

      protected void init_default_properties( )
      {
         lblTextblockcargadetalleid_Internalname = "TEXTBLOCKCARGADETALLEID" ;
         edtavCcargadetalleid_Internalname = "vCCARGADETALLEID" ;
         lblTextblockdocenteid_Internalname = "TEXTBLOCKDOCENTEID" ;
         edtavCdocenteid_Internalname = "vCDOCENTEID" ;
         lblTextblockasignaturaid_Internalname = "TEXTBLOCKASIGNATURAID" ;
         edtavCasignaturaid_Internalname = "vCASIGNATURAID" ;
         lblTextblockescuelaid_Internalname = "TEXTBLOCKESCUELAID" ;
         edtavCescuelaid_Internalname = "vCESCUELAID" ;
         lblTextblockgrupo_Internalname = "TEXTBLOCKGRUPO" ;
         edtavCgrupo_Internalname = "vCGRUPO" ;
         lblTextblockteoria_Internalname = "TEXTBLOCKTEORIA" ;
         edtavCteoria_Internalname = "vCTEORIA" ;
         tblTable2_Internalname = "TABLE2" ;
         grpGroup1_Internalname = "GROUP1" ;
         bttBtn_cancel_Internalname = "BTN_CANCEL" ;
         tblTable4_Internalname = "TABLE4" ;
         tblTable3_Internalname = "TABLE3" ;
         grpGroup2_Internalname = "GROUP2" ;
         tblTable1_Internalname = "TABLE1" ;
         Form.Internalname = "FORM" ;
         subGrid1_Internalname = "GRID1" ;
      }

      public override void initialize_properties( )
      {
         init_default_properties( ) ;
         edtCargaLectivaId_Jsonclick = "" ;
         edtLaboratorio_Jsonclick = "" ;
         edtPractica_Jsonclick = "" ;
         edtTeoria_Jsonclick = "" ;
         edtGrupo_Jsonclick = "" ;
         edtEscuelaId_Jsonclick = "" ;
         edtAsignaturaId_Jsonclick = "" ;
         edtDocenteId_Jsonclick = "" ;
         edtCargaDetalleId_Jsonclick = "" ;
         edtavCteoria_Jsonclick = "" ;
         edtavCgrupo_Jsonclick = "" ;
         edtavCescuelaid_Jsonclick = "" ;
         edtavCasignaturaid_Jsonclick = "" ;
         edtavCdocenteid_Jsonclick = "" ;
         edtavCcargadetalleid_Jsonclick = "" ;
         edtGrupo_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Carga Detalle" ;
         context.GX_msglist.DisplayMode = 1 ;
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
      }

      public override void initialize( )
      {
         gxfirstwebparm = "" ;
         gxfirstwebparm_bkp = "" ;
         AV11cGrupo = "" ;
         sDynURL = "" ;
         FormProcess = "" ;
         GX_FocusControl = "" ;
         Form = new GXWebForm();
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         edtavLinkselection_Internalname = "" ;
         edtCargaDetalleId_Internalname = "" ;
         edtDocenteId_Internalname = "" ;
         edtAsignaturaId_Internalname = "" ;
         edtEscuelaId_Internalname = "" ;
         edtGrupo_Internalname = "" ;
         edtTeoria_Internalname = "" ;
         edtPractica_Internalname = "" ;
         edtLaboratorio_Internalname = "" ;
         edtCargaLectivaId_Internalname = "" ;
         AV5LinkSelection = "" ;
         A27Grupo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV11cGrupo = "" ;
         H000H2_A18CargaLectivaId = new short[1] ;
         H000H2_A30Laboratorio = new short[1] ;
         H000H2_A29Practica = new short[1] ;
         H000H2_A28Teoria = new short[1] ;
         H000H2_A27Grupo = new String[] {""} ;
         H000H2_A11EscuelaId = new short[1] ;
         H000H2_A22AsignaturaId = new short[1] ;
         H000H2_A4DocenteId = new short[1] ;
         H000H2_A42CargaDetalleId = new short[1] ;
         H000H3_AGRID1_nRecordCount = new int[1] ;
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         subGrid1_Linesclass = "" ;
         GXt_char3 = "" ;
         GXt_char2 = "" ;
         GXt_char1 = "" ;
         GXt_char4 = "" ;
         GXt_char5 = "" ;
         GXt_char6 = "" ;
         GXt_char7 = "" ;
         GXt_char8 = "" ;
         Grid1Column = new GXWebColumn();
         GXt_char9 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockcargadetalleid_Jsonclick = "" ;
         lblTextblockdocenteid_Jsonclick = "" ;
         lblTextblockasignaturaid_Jsonclick = "" ;
         lblTextblockescuelaid_Jsonclick = "" ;
         lblTextblockgrupo_Jsonclick = "" ;
         lblTextblockteoria_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char10 = "" ;
         ROClassString = "" ;
         GXt_char11 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00f1__default(),
            new Object[][] {
                new Object[] {
               H000H2_A18CargaLectivaId, H000H2_A30Laboratorio, H000H2_A29Practica, H000H2_A28Teoria, H000H2_A27Grupo, H000H2_A11EscuelaId, H000H2_A22AsignaturaId, H000H2_A4DocenteId, H000H2_A42CargaDetalleId
               }
               , new Object[] {
               H000H3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV12pCargaLectivaId ;
      private short wcpOAV12pCargaLectivaId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_46_idx=1 ;
      private short AV6cCargaDetalleId ;
      private short AV7cDocenteId ;
      private short AV9cAsignaturaId ;
      private short AV10cEscuelaId ;
      private short AV14cTeoria ;
      private short AV13pCargaDetalleId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A42CargaDetalleId ;
      private short A4DocenteId ;
      private short A22AsignaturaId ;
      private short A11EscuelaId ;
      private short A28Teoria ;
      private short A29Practica ;
      private short A30Laboratorio ;
      private short A18CargaLectivaId ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize46 ;
      private int GRID1_nFirstRecordOnPage ;
      private int subGrid1_Islastpage ;
      private int GRID1_nCurrentRecord ;
      private int GRID1_nRecordCount ;
      private int subGrid1_Titlebackcolor ;
      private int subGrid1_Allbackcolor ;
      private int idxLst ;
      private int subGrid1_Backcolor ;
      private String gxfirstwebparm ;
      private String gxfirstwebparm_bkp ;
      private String sGXsfl_46_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtCargaDetalleId_Internalname ;
      private String edtDocenteId_Internalname ;
      private String edtAsignaturaId_Internalname ;
      private String edtEscuelaId_Internalname ;
      private String edtGrupo_Internalname ;
      private String edtTeoria_Internalname ;
      private String edtPractica_Internalname ;
      private String edtLaboratorio_Internalname ;
      private String edtCargaLectivaId_Internalname ;
      private String edtavCcargadetalleid_Internalname ;
      private String scmdbuf ;
      private String edtavCdocenteid_Internalname ;
      private String edtavCasignaturaid_Internalname ;
      private String edtavCescuelaid_Internalname ;
      private String edtavCgrupo_Internalname ;
      private String edtavCteoria_Internalname ;
      private String sStyleString ;
      private String tblTable1_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String grpGroup1_Internalname ;
      private String grpGroup2_Internalname ;
      private String tblTable3_Internalname ;
      private String subGrid1_Internalname ;
      private String subGrid1_Class ;
      private String subGrid1_Linesclass ;
      private String GXt_char3 ;
      private String GXt_char2 ;
      private String GXt_char1 ;
      private String GXt_char4 ;
      private String GXt_char5 ;
      private String GXt_char6 ;
      private String GXt_char7 ;
      private String GXt_char8 ;
      private String edtavLinkselection_Link ;
      private String edtGrupo_Link ;
      private String GXt_char9 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockcargadetalleid_Internalname ;
      private String lblTextblockcargadetalleid_Jsonclick ;
      private String edtavCcargadetalleid_Jsonclick ;
      private String lblTextblockdocenteid_Internalname ;
      private String lblTextblockdocenteid_Jsonclick ;
      private String edtavCdocenteid_Jsonclick ;
      private String lblTextblockasignaturaid_Internalname ;
      private String lblTextblockasignaturaid_Jsonclick ;
      private String edtavCasignaturaid_Jsonclick ;
      private String lblTextblockescuelaid_Internalname ;
      private String lblTextblockescuelaid_Jsonclick ;
      private String edtavCescuelaid_Jsonclick ;
      private String lblTextblockgrupo_Internalname ;
      private String lblTextblockgrupo_Jsonclick ;
      private String edtavCgrupo_Jsonclick ;
      private String lblTextblockteoria_Internalname ;
      private String lblTextblockteoria_Jsonclick ;
      private String edtavCteoria_Jsonclick ;
      private String GXt_char10 ;
      private String ROClassString ;
      private String edtCargaDetalleId_Jsonclick ;
      private String edtDocenteId_Jsonclick ;
      private String edtAsignaturaId_Jsonclick ;
      private String edtEscuelaId_Jsonclick ;
      private String edtGrupo_Jsonclick ;
      private String edtTeoria_Jsonclick ;
      private String edtPractica_Jsonclick ;
      private String edtLaboratorio_Jsonclick ;
      private String edtCargaLectivaId_Jsonclick ;
      private String GXt_char11 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV11cGrupo ;
      private String A27Grupo ;
      private String lV11cGrupo ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000H2_A18CargaLectivaId ;
      private short[] H000H2_A30Laboratorio ;
      private short[] H000H2_A29Practica ;
      private short[] H000H2_A28Teoria ;
      private String[] H000H2_A27Grupo ;
      private short[] H000H2_A11EscuelaId ;
      private short[] H000H2_A22AsignaturaId ;
      private short[] H000H2_A4DocenteId ;
      private short[] H000H2_A42CargaDetalleId ;
      private int[] H000H3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP1_pCargaDetalleId ;
      private GXWebForm Form ;
   }

   public class gx00f1__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmH000H2 ;
          prmH000H2 = new Object[] {
          new Object[] {"@AV12pCargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cCargaDetalleId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cDocenteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cAsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cEscuelaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV11cGrupo",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV14cTeoria",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000H3 ;
          prmH000H3 = new Object[] {
          new Object[] {"@AV12pCargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cCargaDetalleId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7cDocenteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cAsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cEscuelaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV11cGrupo",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV14cTeoria",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000H2", "SELECT [CargaLectivaId], [Laboratorio], [Practica], [Teoria], [Grupo], [EscuelaId], [AsignaturaId], [DocenteId], [CargaDetalleId] FROM [CargaLectivaCargaDetalle] WITH (NOLOCK) WHERE ([CargaLectivaId] = @AV12pCargaLectivaId and [CargaDetalleId] >= @AV6cCargaDetalleId) AND ([DocenteId] >= @AV7cDocenteId) AND ([AsignaturaId] >= @AV9cAsignaturaId) AND ([EscuelaId] >= @AV10cEscuelaId) AND ([Grupo] like @lV11cGrupo) AND ([Teoria] >= @AV14cTeoria) ORDER BY [CargaLectivaId], [CargaDetalleId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000H2,11,0,false,false )
             ,new CursorDef("H000H3", "SELECT COUNT(*) FROM [CargaLectivaCargaDetalle] WITH (NOLOCK) WHERE ([CargaLectivaId] = @AV12pCargaLectivaId and [CargaDetalleId] >= @AV6cCargaDetalleId) AND ([DocenteId] >= @AV7cDocenteId) AND ([AsignaturaId] >= @AV9cAsignaturaId) AND ([EscuelaId] >= @AV10cEscuelaId) AND ([Grupo] like @lV11cGrupo) AND ([Teoria] >= @AV14cTeoria) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000H3,1,0,false,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                break;
             case 1 :
                ((int[]) buf[0])[0] = rslt.getInt(1) ;
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
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (String)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
