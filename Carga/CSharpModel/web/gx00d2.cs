/*
               File: Gx00D2
        Description: Selection List Horas
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 9/28/2014 23:33:21.51
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
   public class gx00d2 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00d2( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00d2( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( short aP0_pCargaLectivaId ,
                           short aP1_pDocenteId ,
                           out short aP2_pHorasId )
      {
         this.AV11pCargaLectivaId = aP0_pCargaLectivaId;
         this.AV12pDocenteId = aP1_pDocenteId;
         this.AV13pHorasId = 0 ;
         executePrivate();
         aP2_pHorasId=this.AV13pHorasId;
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
               nGXsfl_41_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_41_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_41_idx, sGXsfl_41_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize41 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cHorasId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cHorasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cHorasId), 4, 0)));
               AV7cGrupo = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGrupo", AV7cGrupo);
               AV8cTeoria = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTeoria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTeoria), 4, 0)));
               AV9cPractica = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPractica", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cPractica), 4, 0)));
               AV10cLaboratorio = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cLaboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cLaboratorio), 4, 0)));
               AV11pCargaLectivaId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pCargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pCargaLectivaId), 4, 0)));
               AV12pDocenteId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pDocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pDocenteId), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize41, AV6cHorasId, AV7cGrupo, AV8cTeoria, AV9cPractica, AV10cLaboratorio, AV11pCargaLectivaId, AV12pDocenteId) ;
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
               AV11pCargaLectivaId = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pCargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pCargaLectivaId), 4, 0)));
               if ( StringUtil.StrCmp(gxfirstwebparm, "viewer") != 0 )
               {
                  AV12pDocenteId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pDocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pDocenteId), 4, 0)));
                  AV13pHorasId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
                  context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pHorasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pHorasId), 4, 0)));
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
         PA0F2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0F2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00d2.aspx") + "?" + UrlEncode("" +AV11pCargaLectivaId) + "," + UrlEncode("" +AV12pDocenteId) + "," + UrlEncode("" +AV13pHorasId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCHORASID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cHorasId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCGRUPO", StringUtil.RTrim( AV7cGrupo));
         GxWebStd.gx_hidden_field( context, "GXH_vCTEORIA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cTeoria), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCPRACTICA", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cPractica), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCLABORATORIO", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cLaboratorio), 4, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPCARGALECTIVAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV11pCargaLectivaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPDOCENTEID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV12pDocenteId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPHORASID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV13pHorasId), 4, 0, ",", "")));
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
            WE0F2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0F2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00D2" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Horas" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00d2.aspx") + "?" + UrlEncode("" +AV11pCargaLectivaId) + "," + UrlEncode("" +AV12pDocenteId) + "," + UrlEncode("" +AV13pHorasId) ;
      }

      protected void WB0F0( )
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
            wb_table1_2_0F2( true) ;
         }
         else
         {
            wb_table1_2_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0F2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_7-53786", 0) ;
         Form.Meta.addItem("Description", "Selection List Horas", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0F0( ) ;
      }

      protected void WS0F2( )
      {
         START0F2( ) ;
         EVT0F2( ) ;
      }

      protected void EVT0F2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHORASID"), ",", ".") != Convert.ToDecimal( AV6cHorasId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPO"), AV7cGrupo) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTEORIA"), ",", ".") != Convert.ToDecimal( AV8cTeoria )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRACTICA"), ",", ".") != Convert.ToDecimal( AV9cPractica )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLABORATORIO"), ",", ".") != Convert.ToDecimal( AV10cLaboratorio )) )
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
                              nGXsfl_41_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
                              edtHorasId_Internalname = "HORASID_"+sGXsfl_41_idx ;
                              edtGrupo_Internalname = "GRUPO_"+sGXsfl_41_idx ;
                              edtTeoria_Internalname = "TEORIA_"+sGXsfl_41_idx ;
                              edtPractica_Internalname = "PRACTICA_"+sGXsfl_41_idx ;
                              edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_41_idx ;
                              edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_41_idx ;
                              edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_41_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A26HorasId = (short)(context.localUtil.CToN( cgiGet( edtHorasId_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26HorasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A26HorasId), 4, 0)));
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
                              A4DocenteId = (short)(context.localUtil.CToN( cgiGet( edtDocenteId_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110F2 */
                                    E110F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120F2 */
                                    E120F2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Chorasid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHORASID"), ",", ".") != Convert.ToDecimal( AV6cHorasId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cgrupo Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCGRUPO"), AV7cGrupo) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cteoria Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCTEORIA"), ",", ".") != Convert.ToDecimal( AV8cTeoria )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Cpractica Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCPRACTICA"), ",", ".") != Convert.ToDecimal( AV9cPractica )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Claboratorio Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCLABORATORIO"), ",", ".") != Convert.ToDecimal( AV10cLaboratorio )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E130F2 */
                                          E130F2 ();
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

      protected void WE0F2( )
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

      protected void PA0F2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavChorasid_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_41_idx ,
                                       String sGXsfl_41_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
         edtHorasId_Internalname = "HORASID_"+sGXsfl_41_idx ;
         edtGrupo_Internalname = "GRUPO_"+sGXsfl_41_idx ;
         edtTeoria_Internalname = "TEORIA_"+sGXsfl_41_idx ;
         edtPractica_Internalname = "PRACTICA_"+sGXsfl_41_idx ;
         edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_41_idx ;
         edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_41_idx ;
         edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_41_idx ;
         while ( nGXsfl_41_idx <= nRC_Grid1 )
         {
            sendrow_412( ) ;
            nGXsfl_41_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_41_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_41_idx+1)) ;
            sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtHorasId_Internalname = "HORASID_"+sGXsfl_41_idx ;
            edtGrupo_Internalname = "GRUPO_"+sGXsfl_41_idx ;
            edtTeoria_Internalname = "TEORIA_"+sGXsfl_41_idx ;
            edtPractica_Internalname = "PRACTICA_"+sGXsfl_41_idx ;
            edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_41_idx ;
            edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_41_idx ;
            edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_41_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize41 ,
                                        short AV6cHorasId ,
                                        String AV7cGrupo ,
                                        short AV8cTeoria ,
                                        short AV9cPractica ,
                                        short AV10cLaboratorio ,
                                        short AV11pCargaLectivaId ,
                                        short AV12pDocenteId )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize41) ;
         RF0F2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0F2( ) ;
         /* End function Refresh */
      }

      protected void RF0F2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 41 ;
         nGXsfl_41_idx = 1 ;
         sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
         edtHorasId_Internalname = "HORASID_"+sGXsfl_41_idx ;
         edtGrupo_Internalname = "GRUPO_"+sGXsfl_41_idx ;
         edtTeoria_Internalname = "TEORIA_"+sGXsfl_41_idx ;
         edtPractica_Internalname = "PRACTICA_"+sGXsfl_41_idx ;
         edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_41_idx ;
         edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_41_idx ;
         edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_41_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtHorasId_Internalname = "HORASID_"+sGXsfl_41_idx ;
            edtGrupo_Internalname = "GRUPO_"+sGXsfl_41_idx ;
            edtTeoria_Internalname = "TEORIA_"+sGXsfl_41_idx ;
            edtPractica_Internalname = "PRACTICA_"+sGXsfl_41_idx ;
            edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_41_idx ;
            edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_41_idx ;
            edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_41_idx ;
            lV7cGrupo = StringUtil.PadR( StringUtil.RTrim( AV7cGrupo), 2, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGrupo", AV7cGrupo);
            /* Using cursor H000F2 */
            pr_default.execute(0, new Object[] {AV11pCargaLectivaId, AV12pDocenteId, AV6cHorasId, lV7cGrupo, AV8cTeoria, AV9cPractica, AV10cLaboratorio});
            nGXsfl_41_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A4DocenteId = H000F2_A4DocenteId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A4DocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(A4DocenteId), 4, 0)));
               A18CargaLectivaId = H000F2_A18CargaLectivaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A18CargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A18CargaLectivaId), 4, 0)));
               A30Laboratorio = H000F2_A30Laboratorio[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A30Laboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(A30Laboratorio), 4, 0)));
               A29Practica = H000F2_A29Practica[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A29Practica", StringUtil.LTrim( StringUtil.Str( (decimal)(A29Practica), 4, 0)));
               A28Teoria = H000F2_A28Teoria[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A28Teoria", StringUtil.LTrim( StringUtil.Str( (decimal)(A28Teoria), 4, 0)));
               A27Grupo = H000F2_A27Grupo[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A27Grupo", A27Grupo);
               A26HorasId = H000F2_A26HorasId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A26HorasId", StringUtil.LTrim( StringUtil.Str( (decimal)(A26HorasId), 4, 0)));
               /* Execute user event: E120F2 */
               E120F2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 41 ;
            WB0F0( ) ;
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
         lV7cGrupo = StringUtil.PadR( StringUtil.RTrim( AV7cGrupo), 2, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGrupo", AV7cGrupo);
         /* Using cursor H000F3 */
         pr_default.execute(1, new Object[] {AV11pCargaLectivaId, AV12pDocenteId, AV6cHorasId, lV7cGrupo, AV8cTeoria, AV9cPractica, AV10cLaboratorio});
         GRID1_nRecordCount = H000F3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP0F0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110F2 */
         E110F2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavChorasid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavChorasid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCHORASID");
               GX_FocusControl = edtavChorasid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cHorasId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cHorasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cHorasId), 4, 0)));
            }
            else
            {
               AV6cHorasId = (short)(context.localUtil.CToN( cgiGet( edtavChorasid_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cHorasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cHorasId), 4, 0)));
            }
            AV7cGrupo = cgiGet( edtavCgrupo_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGrupo", AV7cGrupo);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCteoria_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCteoria_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCTEORIA");
               GX_FocusControl = edtavCteoria_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV8cTeoria = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTeoria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTeoria), 4, 0)));
            }
            else
            {
               AV8cTeoria = (short)(context.localUtil.CToN( cgiGet( edtavCteoria_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTeoria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTeoria), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCpractica_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCpractica_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCPRACTICA");
               GX_FocusControl = edtavCpractica_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cPractica = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPractica", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cPractica), 4, 0)));
            }
            else
            {
               AV9cPractica = (short)(context.localUtil.CToN( cgiGet( edtavCpractica_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPractica", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cPractica), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavClaboratorio_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavClaboratorio_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCLABORATORIO");
               GX_FocusControl = edtavClaboratorio_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cLaboratorio = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cLaboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cLaboratorio), 4, 0)));
            }
            else
            {
               AV10cLaboratorio = (short)(context.localUtil.CToN( cgiGet( edtavClaboratorio_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cLaboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cLaboratorio), 4, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV11pCargaLectivaId = (short)(context.localUtil.CToN( cgiGet( "vPCARGALECTIVAID"), ",", ".")) ;
            AV12pDocenteId = (short)(context.localUtil.CToN( cgiGet( "vPDOCENTEID"), ",", ".")) ;
            AV13pHorasId = (short)(context.localUtil.CToN( cgiGet( "vPHORASID"), ",", ".")) ;
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
         /* Execute user event: E110F2 */
         E110F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110F2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Horas", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E120F2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_412( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E130F2 */
         E130F2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130F2( )
      {
         /* Enter Routine */
         AV13pHorasId = A26HorasId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pHorasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pHorasId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV13pHorasId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_0F2( bool wbgen )
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
            wb_table2_9_0F2( true) ;
         }
         else
         {
            wb_table2_9_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_0F2e( bool wbgen )
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
            wb_table3_38_0F2( true) ;
         }
         else
         {
            wb_table3_38_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table3_38_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0F2e( true) ;
         }
         else
         {
            wb_table1_2_0F2e( false) ;
         }
      }

      protected void wb_table3_38_0F2( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"41\">") ;
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
               context.SendWebValue( "Id") ;
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
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+"display:none;"+""+"\" "+">") ;
               context.SendWebValue( "Docente Id") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A26HorasId), 4, 0, ".", "")));
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
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A4DocenteId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 41 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_41_idx-1) ;
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
            wb_table4_52_0F2( true) ;
         }
         else
         {
            wb_table4_52_0F2( false) ;
         }
         return  ;
      }

      protected void wb_table4_52_0F2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_38_0F2e( true) ;
         }
         else
         {
            wb_table3_38_0F2e( false) ;
         }
      }

      protected void wb_table4_52_0F2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 55,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(41), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_52_0F2e( true) ;
         }
         else
         {
            wb_table4_52_0F2e( false) ;
         }
      }

      protected void wb_table2_9_0F2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockhorasid_Internalname, "Horas Id", "", "", lblTextblockhorasid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cHorasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cHorasId), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavChorasid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cHorasId), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV6cHorasId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", "", "", "", "", edtavChorasid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockgrupo_Internalname, "Grupo", "", "", lblTextblockgrupo_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cGrupo", AV7cGrupo);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCgrupo_Internalname, StringUtil.RTrim( AV7cGrupo), StringUtil.RTrim( context.localUtil.Format( AV7cGrupo, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCgrupo_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 2, "chr", 1, "row", 2, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockteoria_Internalname, "Teoria", "", "", lblTextblockteoria_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8cTeoria", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8cTeoria), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCteoria_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8cTeoria), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV8cTeoria), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCteoria_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockpractica_Internalname, "Practica", "", "", lblTextblockpractica_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cPractica", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cPractica), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCpractica_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cPractica), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV9cPractica), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCpractica_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocklaboratorio_Internalname, "Laboratorio", "", "", lblTextblocklaboratorio_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cLaboratorio", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cLaboratorio), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_41_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavClaboratorio_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cLaboratorio), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV10cLaboratorio), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(34);\"", "", "", "", "", edtavClaboratorio_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00D2.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_0F2e( true) ;
         }
         else
         {
            wb_table2_9_0F2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV11pCargaLectivaId = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV11pCargaLectivaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV11pCargaLectivaId), 4, 0)));
         AV12pDocenteId = Convert.ToInt16(getParm(obj,1)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV12pDocenteId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV12pDocenteId), 4, 0)));
         AV13pHorasId = Convert.ToInt16(getParm(obj,2)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV13pHorasId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV13pHorasId), 4, 0)));
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
         PA0F2( ) ;
         WS0F2( ) ;
         WE0F2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?2333224");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?53786");
         context.AddJavascriptSource("gx00d2.js", "?2333224");
         /* End function include_jscripts */
      }

      protected void sendrow_412( )
      {
         WB0F0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_41_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_41_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_41_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A26HorasId), 4, 0, ",", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHorasId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A26HorasId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A26HorasId), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtHorasId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtGrupo_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A26HorasId), 4, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtGrupo_Internalname, "Link", edtGrupo_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtGrupo_Internalname,StringUtil.RTrim( A27Grupo),StringUtil.RTrim( context.localUtil.Format( A27Grupo, "")),(String)"",(String)"",(String)edtGrupo_Link,(String)"",(String)"Seleccionar",(String)edtGrupo_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)2,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtTeoria_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A28Teoria), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A28Teoria), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtTeoria_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtPractica_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A29Practica), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A29Practica), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtPractica_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtLaboratorio_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A30Laboratorio), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A30Laboratorio), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtLaboratorio_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCargaLectivaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A18CargaLectivaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A18CargaLectivaId), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCargaLectivaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+"display:none;"+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtDocenteId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A4DocenteId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A4DocenteId), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtDocenteId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)0,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)41,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_41_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_41_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_41_idx+1)) ;
            sGXsfl_41_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_41_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_41_idx ;
            edtHorasId_Internalname = "HORASID_"+sGXsfl_41_idx ;
            edtGrupo_Internalname = "GRUPO_"+sGXsfl_41_idx ;
            edtTeoria_Internalname = "TEORIA_"+sGXsfl_41_idx ;
            edtPractica_Internalname = "PRACTICA_"+sGXsfl_41_idx ;
            edtLaboratorio_Internalname = "LABORATORIO_"+sGXsfl_41_idx ;
            edtCargaLectivaId_Internalname = "CARGALECTIVAID_"+sGXsfl_41_idx ;
            edtDocenteId_Internalname = "DOCENTEID_"+sGXsfl_41_idx ;
         }
         /* End function sendrow_412 */
      }

      protected void init_default_properties( )
      {
         lblTextblockhorasid_Internalname = "TEXTBLOCKHORASID" ;
         edtavChorasid_Internalname = "vCHORASID" ;
         lblTextblockgrupo_Internalname = "TEXTBLOCKGRUPO" ;
         edtavCgrupo_Internalname = "vCGRUPO" ;
         lblTextblockteoria_Internalname = "TEXTBLOCKTEORIA" ;
         edtavCteoria_Internalname = "vCTEORIA" ;
         lblTextblockpractica_Internalname = "TEXTBLOCKPRACTICA" ;
         edtavCpractica_Internalname = "vCPRACTICA" ;
         lblTextblocklaboratorio_Internalname = "TEXTBLOCKLABORATORIO" ;
         edtavClaboratorio_Internalname = "vCLABORATORIO" ;
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
         edtDocenteId_Jsonclick = "" ;
         edtCargaLectivaId_Jsonclick = "" ;
         edtLaboratorio_Jsonclick = "" ;
         edtPractica_Jsonclick = "" ;
         edtTeoria_Jsonclick = "" ;
         edtGrupo_Jsonclick = "" ;
         edtHorasId_Jsonclick = "" ;
         edtavClaboratorio_Jsonclick = "" ;
         edtavCpractica_Jsonclick = "" ;
         edtavCteoria_Jsonclick = "" ;
         edtavCgrupo_Jsonclick = "" ;
         edtavChorasid_Jsonclick = "" ;
         edtGrupo_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Horas" ;
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
         AV7cGrupo = "" ;
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
         edtHorasId_Internalname = "" ;
         edtGrupo_Internalname = "" ;
         edtTeoria_Internalname = "" ;
         edtPractica_Internalname = "" ;
         edtLaboratorio_Internalname = "" ;
         edtCargaLectivaId_Internalname = "" ;
         edtDocenteId_Internalname = "" ;
         AV5LinkSelection = "" ;
         A27Grupo = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV7cGrupo = "" ;
         H000F2_A4DocenteId = new short[1] ;
         H000F2_A18CargaLectivaId = new short[1] ;
         H000F2_A30Laboratorio = new short[1] ;
         H000F2_A29Practica = new short[1] ;
         H000F2_A28Teoria = new short[1] ;
         H000F2_A27Grupo = new String[] {""} ;
         H000F2_A26HorasId = new short[1] ;
         H000F3_AGRID1_nRecordCount = new int[1] ;
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
         Grid1Column = new GXWebColumn();
         GXt_char7 = "" ;
         TempTags = "" ;
         bttBtn_cancel_Jsonclick = "" ;
         lblTextblockhorasid_Jsonclick = "" ;
         lblTextblockgrupo_Jsonclick = "" ;
         lblTextblockteoria_Jsonclick = "" ;
         lblTextblockpractica_Jsonclick = "" ;
         lblTextblocklaboratorio_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00d2__default(),
            new Object[][] {
                new Object[] {
               H000F2_A4DocenteId, H000F2_A18CargaLectivaId, H000F2_A30Laboratorio, H000F2_A29Practica, H000F2_A28Teoria, H000F2_A27Grupo, H000F2_A26HorasId
               }
               , new Object[] {
               H000F3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short AV11pCargaLectivaId ;
      private short AV12pDocenteId ;
      private short wcpOAV11pCargaLectivaId ;
      private short wcpOAV12pDocenteId ;
      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_41_idx=1 ;
      private short AV6cHorasId ;
      private short AV8cTeoria ;
      private short AV9cPractica ;
      private short AV10cLaboratorio ;
      private short AV13pHorasId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A26HorasId ;
      private short A28Teoria ;
      private short A29Practica ;
      private short A30Laboratorio ;
      private short A18CargaLectivaId ;
      private short A4DocenteId ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize41 ;
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
      private String sGXsfl_41_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtHorasId_Internalname ;
      private String edtGrupo_Internalname ;
      private String edtTeoria_Internalname ;
      private String edtPractica_Internalname ;
      private String edtLaboratorio_Internalname ;
      private String edtCargaLectivaId_Internalname ;
      private String edtDocenteId_Internalname ;
      private String edtavChorasid_Internalname ;
      private String scmdbuf ;
      private String edtavCgrupo_Internalname ;
      private String edtavCteoria_Internalname ;
      private String edtavCpractica_Internalname ;
      private String edtavClaboratorio_Internalname ;
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
      private String edtavLinkselection_Link ;
      private String edtGrupo_Link ;
      private String GXt_char7 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockhorasid_Internalname ;
      private String lblTextblockhorasid_Jsonclick ;
      private String edtavChorasid_Jsonclick ;
      private String lblTextblockgrupo_Internalname ;
      private String lblTextblockgrupo_Jsonclick ;
      private String edtavCgrupo_Jsonclick ;
      private String lblTextblockteoria_Internalname ;
      private String lblTextblockteoria_Jsonclick ;
      private String edtavCteoria_Jsonclick ;
      private String lblTextblockpractica_Internalname ;
      private String lblTextblockpractica_Jsonclick ;
      private String edtavCpractica_Jsonclick ;
      private String lblTextblocklaboratorio_Internalname ;
      private String lblTextblocklaboratorio_Jsonclick ;
      private String edtavClaboratorio_Jsonclick ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtHorasId_Jsonclick ;
      private String edtGrupo_Jsonclick ;
      private String edtTeoria_Jsonclick ;
      private String edtPractica_Jsonclick ;
      private String edtLaboratorio_Jsonclick ;
      private String edtCargaLectivaId_Jsonclick ;
      private String edtDocenteId_Jsonclick ;
      private String GXt_char9 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV7cGrupo ;
      private String A27Grupo ;
      private String lV7cGrupo ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000F2_A4DocenteId ;
      private short[] H000F2_A18CargaLectivaId ;
      private short[] H000F2_A30Laboratorio ;
      private short[] H000F2_A29Practica ;
      private short[] H000F2_A28Teoria ;
      private String[] H000F2_A27Grupo ;
      private short[] H000F2_A26HorasId ;
      private int[] H000F3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP2_pHorasId ;
      private GXWebForm Form ;
   }

   public class gx00d2__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000F2 ;
          prmH000F2 = new Object[] {
          new Object[] {"@AV11pCargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12pDocenteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cHorasId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cGrupo",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV8cTeoria",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cPractica",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cLaboratorio",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000F3 ;
          prmH000F3 = new Object[] {
          new Object[] {"@AV11pCargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12pDocenteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6cHorasId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cGrupo",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV8cTeoria",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV9cPractica",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cLaboratorio",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000F2", "SELECT [DocenteId], [CargaLectivaId], [Laboratorio], [Practica], [Teoria], [Grupo], [HorasId] FROM [CargaLectivaDocentesHoras] WITH (NOLOCK) WHERE ([CargaLectivaId] = @AV11pCargaLectivaId and [DocenteId] = @AV12pDocenteId and [HorasId] >= @AV6cHorasId) AND ([Grupo] like @lV7cGrupo) AND ([Teoria] >= @AV8cTeoria) AND ([Practica] >= @AV9cPractica) AND ([Laboratorio] >= @AV10cLaboratorio) ORDER BY [CargaLectivaId], [DocenteId], [HorasId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F2,11,0,false,false )
             ,new CursorDef("H000F3", "SELECT COUNT(*) FROM [CargaLectivaDocentesHoras] WITH (NOLOCK) WHERE ([CargaLectivaId] = @AV11pCargaLectivaId and [DocenteId] = @AV12pDocenteId and [HorasId] >= @AV6cHorasId) AND ([Grupo] like @lV7cGrupo) AND ([Teoria] >= @AV8cTeoria) AND ([Practica] >= @AV9cPractica) AND ([Laboratorio] >= @AV10cLaboratorio) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000F3,1,0,false,false )
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
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
