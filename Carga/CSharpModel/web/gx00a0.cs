/*
               File: Gx00A0
        Description: Selection List Asignatura
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 12/3/2014 8:48:46.36
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
   public class gx00a0 : GXDataArea, System.Web.SessionState.IRequiresSessionState
   {
      public gx00a0( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public gx00a0( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( out short aP0_pAsignaturaId )
      {
         this.AV8pAsignaturaId = 0 ;
         executePrivate();
         aP0_pAsignaturaId=this.AV8pAsignaturaId;
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
               nGXsfl_51_idx = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               sGXsfl_51_idx = GetNextPar( ) ;
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxnrGrid1_newrow( nRC_Grid1, nGXsfl_51_idx, sGXsfl_51_idx) ;
               return  ;
            }
            else if ( StringUtil.StrCmp(gxfirstwebparm, "gxajaxGridRefresh_"+"Grid1") == 0 )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               Grid1_PageSize51 = (int)(NumberUtil.Val( GetNextPar( ), ".")) ;
               AV6cAsignaturaId = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cAsignaturaId), 4, 0)));
               AV7cAsignaturaNombre = GetNextPar( ) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAsignaturaNombre", AV7cAsignaturaNombre);
               AV9cCreditos = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCreditos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cCreditos), 4, 0)));
               AV10cSemestre = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSemestre", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cSemestre), 4, 0)));
               AV14cHorasTeoria1 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cHorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cHorasTeoria1), 4, 0)));
               AV15cHorasPractica2 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cHorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15cHorasPractica2), 4, 0)));
               AV16cHorasLaboratorio3 = (short)(NumberUtil.Val( GetNextPar( ), ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cHorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16cHorasLaboratorio3), 4, 0)));
               setAjaxCallMode();
               if ( ! IsValidAjaxCall( true) )
               {
                  GxWebError = 1 ;
                  return  ;
               }
               gxgrGrid1_refresh( Grid1_PageSize51, AV6cAsignaturaId, AV7cAsignaturaNombre, AV9cCreditos, AV10cSemestre, AV14cHorasTeoria1, AV15cHorasPractica2, AV16cHorasLaboratorio3) ;
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
               AV8pAsignaturaId = (short)(NumberUtil.Val( gxfirstwebparm, ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8pAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8pAsignaturaId), 4, 0)));
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
         PA0C2( ) ;
         gxajaxcallmode = (short)((isAjaxCallMode( ) ? 1 : 0)) ;
         if ( ( gxajaxcallmode == 0 ) && ( GxWebError == 0 ) )
         {
            START0C2( ) ;
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
         context.WriteHtmlTextNl( "<form id=\"MAINFORM\" onsubmit=\"try{return gx.csv.validForm()}catch(e){return true;}\" name=\"MAINFORM\" method=\"post\" action=\""+formatLink("gx00a0.aspx") + "?" + UrlEncode("" +AV8pAsignaturaId)+"\" class=\""+"Form"+"\">") ;
         GxWebStd.gx_hidden_field( context, "_EventName", "");
         GxWebStd.gx_hidden_field( context, "_EventGridId", "");
         GxWebStd.gx_hidden_field( context, "_EventRowId", "");
      }

      public override void RenderHtmlCloseForm( )
      {
         /* Send hidden variables. */
         GxWebStd.gx_hidden_field( context, "GXH_vCASIGNATURAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cAsignaturaId), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCASIGNATURANOMBRE", StringUtil.RTrim( AV7cAsignaturaNombre));
         GxWebStd.gx_hidden_field( context, "GXH_vCCREDITOS", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cCreditos), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCSEMESTRE", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cSemestre), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCHORASTEORIA1", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14cHorasTeoria1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCHORASPRACTICA2", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15cHorasPractica2), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "GXH_vCHORASLABORATORIO3", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16cHorasLaboratorio3), 4, 0, ",", "")));
         /* Send saved values. */
         GxWebStd.gx_hidden_field( context, "nRC_Grid1", StringUtil.LTrim( StringUtil.NToC( (decimal)(nRC_Grid1), 4, 0, ",", "")));
         GxWebStd.gx_hidden_field( context, "vPASIGNATURAID", StringUtil.LTrim( StringUtil.NToC( (decimal)(AV8pAsignaturaId), 4, 0, ",", "")));
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
            WE0C2( ) ;
         }
      }

      public override void DispatchEvents( )
      {
         EVT0C2( ) ;
      }

      public override bool HasEnterEvent( )
      {
         return true ;
      }

      public override String GetPgmname( )
      {
         return "Gx00A0" ;
      }

      public override String GetPgmdesc( )
      {
         return "Selection List Asignatura" ;
      }

      public override GXWebForm GetForm( )
      {
         return Form ;
      }

      public override String GetSelfLink( )
      {
         return formatLink("gx00a0.aspx") + "?" + UrlEncode("" +AV8pAsignaturaId) ;
      }

      protected void WB0C0( )
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
            wb_table1_2_0C2( true) ;
         }
         else
         {
            wb_table1_2_0C2( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_0C2e( bool wbgen )
      {
         if ( wbgen )
         {
         }
         wbLoad = true ;
      }

      protected void START0C2( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         Form.Meta.addItem("Generator", "GeneXus C#", 0) ;
         Form.Meta.addItem("Version", "10_1_7-53786", 0) ;
         Form.Meta.addItem("Description", "Selection List Asignatura", 0) ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP0C0( ) ;
      }

      protected void WS0C2( )
      {
         START0C2( ) ;
         EVT0C2( ) ;
      }

      protected void EVT0C2( )
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
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCASIGNATURAID"), ",", ".") != Convert.ToDecimal( AV6cAsignaturaId )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( StringUtil.StrCmp(cgiGet( "GXH_vCASIGNATURANOMBRE"), AV7cAsignaturaNombre) != 0 )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCREDITOS"), ",", ".") != Convert.ToDecimal( AV9cCreditos )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSEMESTRE"), ",", ".") != Convert.ToDecimal( AV10cSemestre )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHORASTEORIA1"), ",", ".") != Convert.ToDecimal( AV14cHorasTeoria1 )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHORASPRACTICA2"), ",", ".") != Convert.ToDecimal( AV15cHorasPractica2 )) )
                  {
                     GRID1_nFirstRecordOnPage = 0 ;
                  }
                  if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHORASLABORATORIO3"), ",", ".") != Convert.ToDecimal( AV16cHorasLaboratorio3 )) )
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
                              nGXsfl_51_idx = (short)(NumberUtil.Val( sEvtType, ".")) ;
                              sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
                              edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
                              edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_51_idx ;
                              edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_51_idx ;
                              edtCreditos_Internalname = "CREDITOS_"+sGXsfl_51_idx ;
                              edtSemestre_Internalname = "SEMESTRE_"+sGXsfl_51_idx ;
                              edtHorasTeoria1_Internalname = "HORASTEORIA1_"+sGXsfl_51_idx ;
                              edtHorasPractica2_Internalname = "HORASPRACTICA2_"+sGXsfl_51_idx ;
                              edtHorasLaboratorio3_Internalname = "HORASLABORATORIO3_"+sGXsfl_51_idx ;
                              AV5LinkSelection = cgiGet( "GXimg"+edtavLinkselection_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
                              A22AsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtAsignaturaId_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
                              A23AsignaturaNombre = cgiGet( edtAsignaturaNombre_Internalname) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
                              A34Creditos = (short)(context.localUtil.CToN( cgiGet( edtCreditos_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34Creditos", StringUtil.LTrim( StringUtil.Str( (decimal)(A34Creditos), 4, 0)));
                              A35Semestre = (short)(context.localUtil.CToN( cgiGet( edtSemestre_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35Semestre", StringUtil.LTrim( StringUtil.Str( (decimal)(A35Semestre), 4, 0)));
                              A39HorasTeoria1 = (short)(context.localUtil.CToN( cgiGet( edtHorasTeoria1_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39HorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(A39HorasTeoria1), 4, 0)));
                              A40HorasPractica2 = (short)(context.localUtil.CToN( cgiGet( edtHorasPractica2_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40HorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(A40HorasPractica2), 4, 0)));
                              A41HorasLaboratorio3 = (short)(context.localUtil.CToN( cgiGet( edtHorasLaboratorio3_Internalname), ",", ".")) ;
                              context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41HorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(A41HorasLaboratorio3), 4, 0)));
                              sEvtType = StringUtil.Right( sEvt, 1) ;
                              if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                              {
                                 sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                                 if ( StringUtil.StrCmp(sEvt, "START") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E110C2 */
                                    E110C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "LOAD") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    dynload_actions( ) ;
                                    /* Execute user event: E120C2 */
                                    E120C2 ();
                                 }
                                 else if ( StringUtil.StrCmp(sEvt, "ENTER") == 0 )
                                 {
                                    context.wbHandled = 1 ;
                                    if ( ! wbErr )
                                    {
                                       Rfr0gs = false ;
                                       /* Set Refresh If Casignaturaid Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCASIGNATURAID"), ",", ".") != Convert.ToDecimal( AV6cAsignaturaId )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Casignaturanombre Changed */
                                       if ( StringUtil.StrCmp(cgiGet( "GXH_vCASIGNATURANOMBRE"), AV7cAsignaturaNombre) != 0 )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Ccreditos Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCCREDITOS"), ",", ".") != Convert.ToDecimal( AV9cCreditos )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Csemestre Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCSEMESTRE"), ",", ".") != Convert.ToDecimal( AV10cSemestre )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Chorasteoria1 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHORASTEORIA1"), ",", ".") != Convert.ToDecimal( AV14cHorasTeoria1 )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Choraspractica2 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHORASPRACTICA2"), ",", ".") != Convert.ToDecimal( AV15cHorasPractica2 )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       /* Set Refresh If Choraslaboratorio3 Changed */
                                       if ( ( context.localUtil.CToN( cgiGet( "GXH_vCHORASLABORATORIO3"), ",", ".") != Convert.ToDecimal( AV16cHorasLaboratorio3 )) )
                                       {
                                          Rfr0gs = true ;
                                       }
                                       if ( ! Rfr0gs )
                                       {
                                          /* Execute user event: E130C2 */
                                          E130C2 ();
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

      protected void WE0C2( )
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

      protected void PA0C2( )
      {
         if ( nDonePA == 0 )
         {
            GX_FocusControl = edtavCasignaturaid_Internalname ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void gxnrGrid1_newrow( short nRC_Grid1 ,
                                       short nGXsfl_51_idx ,
                                       String sGXsfl_51_idx )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_51_idx ;
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_51_idx ;
         edtCreditos_Internalname = "CREDITOS_"+sGXsfl_51_idx ;
         edtSemestre_Internalname = "SEMESTRE_"+sGXsfl_51_idx ;
         edtHorasTeoria1_Internalname = "HORASTEORIA1_"+sGXsfl_51_idx ;
         edtHorasPractica2_Internalname = "HORASPRACTICA2_"+sGXsfl_51_idx ;
         edtHorasLaboratorio3_Internalname = "HORASLABORATORIO3_"+sGXsfl_51_idx ;
         while ( nGXsfl_51_idx <= nRC_Grid1 )
         {
            sendrow_512( ) ;
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_51_idx ;
            edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_51_idx ;
            edtCreditos_Internalname = "CREDITOS_"+sGXsfl_51_idx ;
            edtSemestre_Internalname = "SEMESTRE_"+sGXsfl_51_idx ;
            edtHorasTeoria1_Internalname = "HORASTEORIA1_"+sGXsfl_51_idx ;
            edtHorasPractica2_Internalname = "HORASPRACTICA2_"+sGXsfl_51_idx ;
            edtHorasLaboratorio3_Internalname = "HORASLABORATORIO3_"+sGXsfl_51_idx ;
         }
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxnrGrid1_newrow */
      }

      protected void gxgrGrid1_refresh( int Grid1_PageSize51 ,
                                        short AV6cAsignaturaId ,
                                        String AV7cAsignaturaNombre ,
                                        short AV9cCreditos ,
                                        short AV10cSemestre ,
                                        short AV14cHorasTeoria1 ,
                                        short AV15cHorasPractica2 ,
                                        short AV16cHorasLaboratorio3 )
      {
         GxWebStd.set_html_headers( context, 0, "", "");
         disableOutput();
         subGrid1_Rows = (short)(Grid1_PageSize51) ;
         RF0C2( ) ;
         enableOutput();
         context.GX_webresponse.AddString(Grid1Container.ToJavascriptSource());
         /* End function gxgrGrid1_refresh */
      }

      protected void Refresh( )
      {
         RF0C2( ) ;
         /* End function Refresh */
      }

      protected void RF0C2( )
      {
         Grid1Container.PageSize = subGrid1_Recordsperpage( ) ;
         wbStart = 51 ;
         nGXsfl_51_idx = 1 ;
         sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
         edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
         edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_51_idx ;
         edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_51_idx ;
         edtCreditos_Internalname = "CREDITOS_"+sGXsfl_51_idx ;
         edtSemestre_Internalname = "SEMESTRE_"+sGXsfl_51_idx ;
         edtHorasTeoria1_Internalname = "HORASTEORIA1_"+sGXsfl_51_idx ;
         edtHorasPractica2_Internalname = "HORASPRACTICA2_"+sGXsfl_51_idx ;
         edtHorasLaboratorio3_Internalname = "HORASLABORATORIO3_"+sGXsfl_51_idx ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_51_idx ;
            edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_51_idx ;
            edtCreditos_Internalname = "CREDITOS_"+sGXsfl_51_idx ;
            edtSemestre_Internalname = "SEMESTRE_"+sGXsfl_51_idx ;
            edtHorasTeoria1_Internalname = "HORASTEORIA1_"+sGXsfl_51_idx ;
            edtHorasPractica2_Internalname = "HORASPRACTICA2_"+sGXsfl_51_idx ;
            edtHorasLaboratorio3_Internalname = "HORASLABORATORIO3_"+sGXsfl_51_idx ;
            lV7cAsignaturaNombre = StringUtil.PadR( StringUtil.RTrim( AV7cAsignaturaNombre), 60, "%") ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAsignaturaNombre", AV7cAsignaturaNombre);
            /* Using cursor H000C2 */
            pr_default.execute(0, new Object[] {AV6cAsignaturaId, lV7cAsignaturaNombre, AV9cCreditos, AV10cSemestre, AV14cHorasTeoria1, AV15cHorasPractica2, AV16cHorasLaboratorio3});
            nGXsfl_51_idx = 1 ;
            GRID1_nEOF = 0 ;
            while ( ( (pr_default.getStatus(0) != 101) ) && ( ( ( 10 == 0 ) || ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) ) )
            {
               A41HorasLaboratorio3 = H000C2_A41HorasLaboratorio3[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A41HorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(A41HorasLaboratorio3), 4, 0)));
               A40HorasPractica2 = H000C2_A40HorasPractica2[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A40HorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(A40HorasPractica2), 4, 0)));
               A39HorasTeoria1 = H000C2_A39HorasTeoria1[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A39HorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(A39HorasTeoria1), 4, 0)));
               A35Semestre = H000C2_A35Semestre[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A35Semestre", StringUtil.LTrim( StringUtil.Str( (decimal)(A35Semestre), 4, 0)));
               A34Creditos = H000C2_A34Creditos[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A34Creditos", StringUtil.LTrim( StringUtil.Str( (decimal)(A34Creditos), 4, 0)));
               A23AsignaturaNombre = H000C2_A23AsignaturaNombre[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A23AsignaturaNombre", A23AsignaturaNombre);
               A22AsignaturaId = H000C2_A22AsignaturaId[0] ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "A22AsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(A22AsignaturaId), 4, 0)));
               /* Execute user event: E120C2 */
               E120C2 ();
               pr_default.readNext(0);
            }
            GRID1_nEOF = (short)(((pr_default.getStatus(0) == 101) ? 1 : 0)) ;
            pr_default.close(0);
            wbEnd = 51 ;
            WB0C0( ) ;
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
         lV7cAsignaturaNombre = StringUtil.PadR( StringUtil.RTrim( AV7cAsignaturaNombre), 60, "%") ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAsignaturaNombre", AV7cAsignaturaNombre);
         /* Using cursor H000C3 */
         pr_default.execute(1, new Object[] {AV6cAsignaturaId, lV7cAsignaturaNombre, AV9cCreditos, AV10cSemestre, AV14cHorasTeoria1, AV15cHorasPractica2, AV16cHorasLaboratorio3});
         GRID1_nRecordCount = H000C3_AGRID1_nRecordCount[0] ;
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

      protected void STRUP0C0( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E110C2 */
         E110C2 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            /* Read variables values. */
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCasignaturaid_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCasignaturaid_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCASIGNATURAID");
               GX_FocusControl = edtavCasignaturaid_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV6cAsignaturaId = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cAsignaturaId), 4, 0)));
            }
            else
            {
               AV6cAsignaturaId = (short)(context.localUtil.CToN( cgiGet( edtavCasignaturaid_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cAsignaturaId), 4, 0)));
            }
            AV7cAsignaturaNombre = cgiGet( edtavCasignaturanombre_Internalname) ;
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAsignaturaNombre", AV7cAsignaturaNombre);
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCcreditos_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCcreditos_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCCREDITOS");
               GX_FocusControl = edtavCcreditos_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV9cCreditos = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCreditos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cCreditos), 4, 0)));
            }
            else
            {
               AV9cCreditos = (short)(context.localUtil.CToN( cgiGet( edtavCcreditos_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCreditos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cCreditos), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavCsemestre_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavCsemestre_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCSEMESTRE");
               GX_FocusControl = edtavCsemestre_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV10cSemestre = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSemestre", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cSemestre), 4, 0)));
            }
            else
            {
               AV10cSemestre = (short)(context.localUtil.CToN( cgiGet( edtavCsemestre_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSemestre", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cSemestre), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavChorasteoria1_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavChorasteoria1_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCHORASTEORIA1");
               GX_FocusControl = edtavChorasteoria1_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV14cHorasTeoria1 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cHorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cHorasTeoria1), 4, 0)));
            }
            else
            {
               AV14cHorasTeoria1 = (short)(context.localUtil.CToN( cgiGet( edtavChorasteoria1_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cHorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cHorasTeoria1), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavChoraspractica2_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavChoraspractica2_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCHORASPRACTICA2");
               GX_FocusControl = edtavChoraspractica2_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV15cHorasPractica2 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cHorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15cHorasPractica2), 4, 0)));
            }
            else
            {
               AV15cHorasPractica2 = (short)(context.localUtil.CToN( cgiGet( edtavChoraspractica2_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cHorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15cHorasPractica2), 4, 0)));
            }
            if ( ( ( context.localUtil.CToN( cgiGet( edtavChoraslaboratorio3_Internalname), ",", ".") < Convert.ToDecimal( 0 )) ) || ( ( context.localUtil.CToN( cgiGet( edtavChoraslaboratorio3_Internalname), ",", ".") > Convert.ToDecimal( 9999 )) ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_badnum"), 1, "vCHORASLABORATORIO3");
               GX_FocusControl = edtavChoraslaboratorio3_Internalname ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "GX_FocusControl", GX_FocusControl);
               wbErr = true ;
               AV16cHorasLaboratorio3 = 0 ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cHorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16cHorasLaboratorio3), 4, 0)));
            }
            else
            {
               AV16cHorasLaboratorio3 = (short)(context.localUtil.CToN( cgiGet( edtavChoraslaboratorio3_Internalname), ",", ".")) ;
               context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cHorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16cHorasLaboratorio3), 4, 0)));
            }
            /* Read saved values. */
            nRC_Grid1 = (short)(context.localUtil.CToN( cgiGet( "nRC_Grid1"), ",", ".")) ;
            AV8pAsignaturaId = (short)(context.localUtil.CToN( cgiGet( "vPASIGNATURAID"), ",", ".")) ;
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
         /* Execute user event: E110C2 */
         E110C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E110C2( )
      {
         /* Start Routine */
         Form.Caption = StringUtil.Format( "Lista de Selección %1", "Asignatura", "", "", "", "", "", "", "", "") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, "FORM", "Caption", Form.Caption);
      }

      private void E120C2( )
      {
         /* Load Routine */
         AV5LinkSelection = context.GetImagePath( "3914535b-0c03-44c5-9538-906a99cdd2bc", "", "Modern") ;
         context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtavLinkselection_Internalname, "Bitmap", context.convertURL( AV5LinkSelection));
         if ( ( subGrid1_Islastpage == 1 ) || ( 10 == 0 ) || ( ( GRID1_nCurrentRecord >= GRID1_nFirstRecordOnPage ) && ( GRID1_nCurrentRecord < GRID1_nFirstRecordOnPage + subGrid1_Recordsperpage( ) ) ) )
         {
            sendrow_512( ) ;
         }
         GRID1_nCurrentRecord = (int)(GRID1_nCurrentRecord+1) ;
      }

      public void GXEnter( )
      {
         /* Execute user event: E130C2 */
         E130C2 ();
         if ( returnInSub )
         {
            returnInSub = true;
            if (true) return;
         }
      }

      protected void E130C2( )
      {
         /* Enter Routine */
         AV8pAsignaturaId = A22AsignaturaId ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8pAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8pAsignaturaId), 4, 0)));
         context.setWebReturnParms(new Object[] {(short)AV8pAsignaturaId});
         context.nUserReturn = 1 ;
         returnInSub = true;
         if (true) return;
      }

      protected void wb_table1_2_0C2( bool wbgen )
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
            wb_table2_9_0C2( true) ;
         }
         else
         {
            wb_table2_9_0C2( false) ;
         }
         return  ;
      }

      protected void wb_table2_9_0C2e( bool wbgen )
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
            wb_table3_48_0C2( true) ;
         }
         else
         {
            wb_table3_48_0C2( false) ;
         }
         return  ;
      }

      protected void wb_table3_48_0C2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</fieldset>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_0C2e( true) ;
         }
         else
         {
            wb_table1_2_0C2e( false) ;
         }
      }

      protected void wb_table3_48_0C2( bool wbgen )
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
               context.WriteHtmlText( "<div id=\""+"Grid1Container"+"DivS\" gxgridid=\"51\">") ;
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
               context.SendWebValue( "Nombre") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Creditos") ;
               context.WriteHtmlTextNl( "</th>") ;
               context.WriteHtmlText( "<th align=\""+"right"+"\" "+" nowrap=\"nowrap\" "+" class=\""+subGrid1_Linesclass+"\" "+" style=\""+((-1==0) ? "display:none;" : "")+""+"\" "+">") ;
               context.SendWebValue( "Semestre") ;
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
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.RTrim( A23AsignaturaNombre));
               Grid1Column.AddObjectProperty("Link", StringUtil.RTrim( edtAsignaturaNombre_Link));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A34Creditos), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A35Semestre), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A39HorasTeoria1), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A40HorasPractica2), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Column = GXWebColumn.GetNew(isAjaxCallMode( )) ;
               Grid1Column.AddObjectProperty("Value", StringUtil.LTrim( StringUtil.NToC( (decimal)(A41HorasLaboratorio3), 4, 0, ".", "")));
               Grid1Container.AddColumnProperties(Grid1Column);
               Grid1Container.AddObjectProperty("Allowselection", "false");
               Grid1Container.AddObjectProperty("Allowcollapsing", "false");
               Grid1Container.AddObjectProperty("Collapsed", StringUtil.LTrim( StringUtil.NToC( (decimal)(subGrid1_Collapsed), 9, 0, ".", "")));
            }
         }
         if ( wbEnd == 51 )
         {
            wbEnd = 0 ;
            nRC_Grid1 = (short)(nGXsfl_51_idx-1) ;
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
            wb_table4_62_0C2( true) ;
         }
         else
         {
            wb_table4_62_0C2( false) ;
         }
         return  ;
      }

      protected void wb_table4_62_0C2e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_48_0C2e( true) ;
         }
         else
         {
            wb_table3_48_0C2e( false) ;
         }
      }

      protected void wb_table4_62_0C2( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 65,'',false,'',0)\"" ;
            ClassString = "BtnCancel" ;
            StyleString = "" ;
            GxWebStd.gx_button_ctrl( context, bttBtn_cancel_Internalname, "gx.evt.setGridEvt("+StringUtil.Str( (decimal)(51), 3, 0)+","+"null"+");", "Cancelar", bttBtn_cancel_Jsonclick, 1, "Cancelar", "", StyleString, ClassString, 1, 1, "rounded", "ECANCEL.", TempTags, "", context.GetButtonType( ), "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_62_0C2e( true) ;
         }
         else
         {
            wb_table4_62_0C2e( false) ;
         }
      }

      protected void wb_table2_9_0C2( bool wbgen )
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
            GxWebStd.gx_label_ctrl( context, lblTextblockasignaturaid_Internalname, "Asignatura Id", "", "", lblTextblockasignaturaid_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV6cAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV6cAsignaturaId), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 14,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasignaturaid_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV6cAsignaturaId), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV6cAsignaturaId), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(14);\"", "", "", "", "", edtavCasignaturaid_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockasignaturanombre_Internalname, "Asignatura Nombre", "", "", lblTextblockasignaturanombre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV7cAsignaturaNombre", AV7cAsignaturaNombre);
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 19,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCasignaturanombre_Internalname, StringUtil.RTrim( AV7cAsignaturaNombre), StringUtil.RTrim( context.localUtil.Format( AV7cAsignaturaNombre, "")), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+""+";gx.evt.onblur(19);\"", "", "", "", "", edtavCasignaturanombre_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 60, "chr", 1, "row", 60, 0, 0, 0, 1, -1, true, "left", "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockcreditos_Internalname, "Creditos", "", "", lblTextblockcreditos_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV9cCreditos", StringUtil.LTrim( StringUtil.Str( (decimal)(AV9cCreditos), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 24,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCcreditos_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV9cCreditos), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV9cCreditos), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(24);\"", "", "", "", "", edtavCcreditos_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblocksemestre_Internalname, "Semestre", "", "", lblTextblocksemestre_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV10cSemestre", StringUtil.LTrim( StringUtil.Str( (decimal)(AV10cSemestre), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 29,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavCsemestre_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV10cSemestre), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV10cSemestre), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(29);\"", "", "", "", "", edtavCsemestre_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockhorasteoria1_Internalname, "H. Teoria", "", "", lblTextblockhorasteoria1_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV14cHorasTeoria1", StringUtil.LTrim( StringUtil.Str( (decimal)(AV14cHorasTeoria1), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 34,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavChorasteoria1_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV14cHorasTeoria1), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV14cHorasTeoria1), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(34);\"", "", "", "", "", edtavChorasteoria1_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockhoraspractica2_Internalname, "H. Practica", "", "", lblTextblockhoraspractica2_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV15cHorasPractica2", StringUtil.LTrim( StringUtil.Str( (decimal)(AV15cHorasPractica2), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 39,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavChoraspractica2_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV15cHorasPractica2), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV15cHorasPractica2), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(39);\"", "", "", "", "", edtavChoraspractica2_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            /* Text block */
            ClassString = "TextBlock" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockhoraslaboratorio3_Internalname, "H. Laboratorio", "", "", lblTextblockhoraslaboratorio3_Jsonclick, "", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            /* Single line edit */
            context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV16cHorasLaboratorio3", StringUtil.LTrim( StringUtil.Str( (decimal)(AV16cHorasLaboratorio3), 4, 0)));
            TempTags = "  onfocus=\"gx.evt.onfocus(this, 44,'',false,'" + sGXsfl_51_idx + "',0)\"" ;
            ClassString = "Attribute" ;
            StyleString = "" ;
            GxWebStd.gx_single_line_edit( context, edtavChoraslaboratorio3_Internalname, StringUtil.LTrim( StringUtil.NToC( (decimal)(AV16cHorasLaboratorio3), 4, 0, ",", "")), context.localUtil.Format( (decimal)(AV16cHorasLaboratorio3), "ZZZ9"), TempTags+" onchange=\"gx.evt.onchange(this)\" "+" onblur=\""+"gx.num.valid_integer( this,'.');"+";gx.evt.onblur(44);\"", "", "", "", "", edtavChoraslaboratorio3_Jsonclick, 0, ClassString, StyleString, "", 1, 1, 0, 4, "chr", 1, "row", 4, 0, 0, 0, 1, -1, true, "right", "HLP_Gx00A0.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_9_0C2e( true) ;
         }
         else
         {
            wb_table2_9_0C2e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
         AV8pAsignaturaId = Convert.ToInt16(getParm(obj,0)) ;
         context.httpAjaxContext.ajax_rsp_assign_attri("", false, "AV8pAsignaturaId", StringUtil.LTrim( StringUtil.Str( (decimal)(AV8pAsignaturaId), 4, 0)));
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
         PA0C2( ) ;
         WS0C2( ) ;
         WE0C2( ) ;
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
            context.AddJavascriptSource(StringUtil.RTrim( Form.Jscriptsrc.Item(idxLst)), "?8484687");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("messages.spa.js", "?53786");
         context.AddJavascriptSource("gx00a0.js", "?8484688");
         /* End function include_jscripts */
      }

      protected void sendrow_512( )
      {
         WB0C0( ) ;
         if ( ( 10 * 1 == 0 ) || ( nGXsfl_51_idx <= subGrid1_Recordsperpage( ) * 1 ) )
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
               if ( ((int)(nGXsfl_51_idx) % (2)) == 0 )
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
               context.WriteHtmlText( " gxrow=\""+sGXsfl_51_idx+"\">") ;
            }
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+""+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Static Bitmap Variable */
            edtavLinkselection_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ",", "")))+"'"+"]);" ;
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
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsignaturaId_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A22AsignaturaId), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtAsignaturaId_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"left"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            edtAsignaturaNombre_Link = "javascript:gx.popup.gxReturn(["+"'"+GXUtil.EncodeJSConstant( StringUtil.LTrim( StringUtil.NToC( (decimal)(A22AsignaturaId), 4, 0, ",", "")))+"'"+"]);" ;
            context.httpAjaxContext.ajax_rsp_assign_prop("", false, edtAsignaturaNombre_Internalname, "Link", edtAsignaturaNombre_Link);
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtAsignaturaNombre_Internalname,StringUtil.RTrim( A23AsignaturaNombre),StringUtil.RTrim( context.localUtil.Format( A23AsignaturaNombre, "")),(String)"",(String)"",(String)edtAsignaturaNombre_Link,(String)"",(String)"Seleccionar",(String)edtAsignaturaNombre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)60,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"left"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtCreditos_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A34Creditos), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A34Creditos), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtCreditos_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtSemestre_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A35Semestre), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A35Semestre), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtSemestre_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHorasTeoria1_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A39HorasTeoria1), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A39HorasTeoria1), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtHorasTeoria1_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHorasPractica2_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A40HorasPractica2), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A40HorasPractica2), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtHorasPractica2_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            /* Subfile cell */
            if ( Grid1Container.GetWrapped() == 1 )
            {
               context.WriteHtmlText( "<td valign=\"middle\" align=\""+"right"+"\""+" style=\""+((-1==0) ? "display:none;" : "")+"\">") ;
            }
            /* Single line edit */
            ClassString = "Attribute" ;
            StyleString = "" ;
            ROClassString = ClassString ;
            Grid1Row.AddColumnProperties("edit", 1, isAjaxCallMode( ), new Object[] {(String)edtHorasLaboratorio3_Internalname,StringUtil.LTrim( StringUtil.NToC( (decimal)(A41HorasLaboratorio3), 4, 0, ",", "")),context.localUtil.Format( (decimal)(A41HorasLaboratorio3), "ZZZ9"),(String)"",(String)"",(String)"",(String)"",(String)"",(String)edtHorasLaboratorio3_Jsonclick,(short)0,(String)ClassString,(String)StyleString,(String)ROClassString,(short)-1,(short)0,(short)0,(short)0,(String)"px",(short)17,(String)"px",(short)4,(short)0,(short)0,(short)51,(short)1,(short)1,(bool)true,(String)"right"});
            Grid1Container.AddRow(Grid1Row);
            nGXsfl_51_idx = (short)(((subGrid1_Islastpage==1)&&(nGXsfl_51_idx+1>subGrid1_Recordsperpage( )) ? 1 : nGXsfl_51_idx+1)) ;
            sGXsfl_51_idx = StringUtil.PadL( StringUtil.LTrim( StringUtil.Str( (decimal)(nGXsfl_51_idx), 4, 0)), 4, "0") ;
            edtavLinkselection_Internalname = "vLINKSELECTION_"+sGXsfl_51_idx ;
            edtAsignaturaId_Internalname = "ASIGNATURAID_"+sGXsfl_51_idx ;
            edtAsignaturaNombre_Internalname = "ASIGNATURANOMBRE_"+sGXsfl_51_idx ;
            edtCreditos_Internalname = "CREDITOS_"+sGXsfl_51_idx ;
            edtSemestre_Internalname = "SEMESTRE_"+sGXsfl_51_idx ;
            edtHorasTeoria1_Internalname = "HORASTEORIA1_"+sGXsfl_51_idx ;
            edtHorasPractica2_Internalname = "HORASPRACTICA2_"+sGXsfl_51_idx ;
            edtHorasLaboratorio3_Internalname = "HORASLABORATORIO3_"+sGXsfl_51_idx ;
         }
         /* End function sendrow_512 */
      }

      protected void init_default_properties( )
      {
         lblTextblockasignaturaid_Internalname = "TEXTBLOCKASIGNATURAID" ;
         edtavCasignaturaid_Internalname = "vCASIGNATURAID" ;
         lblTextblockasignaturanombre_Internalname = "TEXTBLOCKASIGNATURANOMBRE" ;
         edtavCasignaturanombre_Internalname = "vCASIGNATURANOMBRE" ;
         lblTextblockcreditos_Internalname = "TEXTBLOCKCREDITOS" ;
         edtavCcreditos_Internalname = "vCCREDITOS" ;
         lblTextblocksemestre_Internalname = "TEXTBLOCKSEMESTRE" ;
         edtavCsemestre_Internalname = "vCSEMESTRE" ;
         lblTextblockhorasteoria1_Internalname = "TEXTBLOCKHORASTEORIA1" ;
         edtavChorasteoria1_Internalname = "vCHORASTEORIA1" ;
         lblTextblockhoraspractica2_Internalname = "TEXTBLOCKHORASPRACTICA2" ;
         edtavChoraspractica2_Internalname = "vCHORASPRACTICA2" ;
         lblTextblockhoraslaboratorio3_Internalname = "TEXTBLOCKHORASLABORATORIO3" ;
         edtavChoraslaboratorio3_Internalname = "vCHORASLABORATORIO3" ;
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
         edtHorasLaboratorio3_Jsonclick = "" ;
         edtHorasPractica2_Jsonclick = "" ;
         edtHorasTeoria1_Jsonclick = "" ;
         edtSemestre_Jsonclick = "" ;
         edtCreditos_Jsonclick = "" ;
         edtAsignaturaNombre_Jsonclick = "" ;
         edtAsignaturaId_Jsonclick = "" ;
         edtavChoraslaboratorio3_Jsonclick = "" ;
         edtavChoraspractica2_Jsonclick = "" ;
         edtavChorasteoria1_Jsonclick = "" ;
         edtavCsemestre_Jsonclick = "" ;
         edtavCcreditos_Jsonclick = "" ;
         edtavCasignaturanombre_Jsonclick = "" ;
         edtavCasignaturaid_Jsonclick = "" ;
         edtAsignaturaNombre_Link = "" ;
         edtavLinkselection_Link = "" ;
         subGrid1_Class = "Grid" ;
         subGrid1_Backcolorstyle = 2 ;
         Form.Headerrawhtml = "" ;
         Form.Background = "" ;
         Form.Backcolor = (int)(0xFFFFFF) ;
         Form.Caption = "Selection List Asignatura" ;
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
         AV7cAsignaturaNombre = "" ;
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
         edtAsignaturaId_Internalname = "" ;
         edtAsignaturaNombre_Internalname = "" ;
         edtCreditos_Internalname = "" ;
         edtSemestre_Internalname = "" ;
         edtHorasTeoria1_Internalname = "" ;
         edtHorasPractica2_Internalname = "" ;
         edtHorasLaboratorio3_Internalname = "" ;
         AV5LinkSelection = "" ;
         A23AsignaturaNombre = "" ;
         Grid1Container = new GXWebGrid( context);
         scmdbuf = "" ;
         lV7cAsignaturaNombre = "" ;
         H000C2_A41HorasLaboratorio3 = new short[1] ;
         H000C2_A40HorasPractica2 = new short[1] ;
         H000C2_A39HorasTeoria1 = new short[1] ;
         H000C2_A35Semestre = new short[1] ;
         H000C2_A34Creditos = new short[1] ;
         H000C2_A23AsignaturaNombre = new String[] {""} ;
         H000C2_A22AsignaturaId = new short[1] ;
         H000C3_AGRID1_nRecordCount = new int[1] ;
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
         lblTextblockasignaturaid_Jsonclick = "" ;
         lblTextblockasignaturanombre_Jsonclick = "" ;
         lblTextblockcreditos_Jsonclick = "" ;
         lblTextblocksemestre_Jsonclick = "" ;
         lblTextblockhorasteoria1_Jsonclick = "" ;
         lblTextblockhoraspractica2_Jsonclick = "" ;
         lblTextblockhoraslaboratorio3_Jsonclick = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         Grid1Row = new GXWebRow();
         GXt_char8 = "" ;
         ROClassString = "" ;
         GXt_char9 = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.gx00a0__default(),
            new Object[][] {
                new Object[] {
               H000C2_A41HorasLaboratorio3, H000C2_A40HorasPractica2, H000C2_A39HorasTeoria1, H000C2_A35Semestre, H000C2_A34Creditos, H000C2_A23AsignaturaNombre, H000C2_A22AsignaturaId
               }
               , new Object[] {
               H000C3_AGRID1_nRecordCount
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short nGotPars ;
      private short GxWebError ;
      private short nRC_Grid1 ;
      private short nGXsfl_51_idx=1 ;
      private short AV6cAsignaturaId ;
      private short AV9cCreditos ;
      private short AV10cSemestre ;
      private short AV14cHorasTeoria1 ;
      private short AV15cHorasPractica2 ;
      private short AV16cHorasLaboratorio3 ;
      private short AV8pAsignaturaId ;
      private short initialized ;
      private short gxajaxcallmode ;
      private short GRID1_nEOF ;
      private short wbEnd ;
      private short wbStart ;
      private short A22AsignaturaId ;
      private short A34Creditos ;
      private short A35Semestre ;
      private short A39HorasTeoria1 ;
      private short A40HorasPractica2 ;
      private short A41HorasLaboratorio3 ;
      private short nDonePA ;
      private short subGrid1_Rows ;
      private short subGrid1_Backcolorstyle ;
      private short subGrid1_Titlebackstyle ;
      private short subGrid1_Collapsed ;
      private short nGXWrapped ;
      private short subGrid1_Backstyle ;
      private int Grid1_PageSize51 ;
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
      private String sGXsfl_51_idx="0001" ;
      private String sDynURL ;
      private String FormProcess ;
      private String GX_FocusControl ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String edtavLinkselection_Internalname ;
      private String edtAsignaturaId_Internalname ;
      private String edtAsignaturaNombre_Internalname ;
      private String edtCreditos_Internalname ;
      private String edtSemestre_Internalname ;
      private String edtHorasTeoria1_Internalname ;
      private String edtHorasPractica2_Internalname ;
      private String edtHorasLaboratorio3_Internalname ;
      private String edtavCasignaturaid_Internalname ;
      private String scmdbuf ;
      private String edtavCasignaturanombre_Internalname ;
      private String edtavCcreditos_Internalname ;
      private String edtavCsemestre_Internalname ;
      private String edtavChorasteoria1_Internalname ;
      private String edtavChoraspractica2_Internalname ;
      private String edtavChoraslaboratorio3_Internalname ;
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
      private String edtAsignaturaNombre_Link ;
      private String GXt_char7 ;
      private String tblTable4_Internalname ;
      private String TempTags ;
      private String bttBtn_cancel_Internalname ;
      private String bttBtn_cancel_Jsonclick ;
      private String tblTable2_Internalname ;
      private String lblTextblockasignaturaid_Internalname ;
      private String lblTextblockasignaturaid_Jsonclick ;
      private String edtavCasignaturaid_Jsonclick ;
      private String lblTextblockasignaturanombre_Internalname ;
      private String lblTextblockasignaturanombre_Jsonclick ;
      private String edtavCasignaturanombre_Jsonclick ;
      private String lblTextblockcreditos_Internalname ;
      private String lblTextblockcreditos_Jsonclick ;
      private String edtavCcreditos_Jsonclick ;
      private String lblTextblocksemestre_Internalname ;
      private String lblTextblocksemestre_Jsonclick ;
      private String edtavCsemestre_Jsonclick ;
      private String lblTextblockhorasteoria1_Internalname ;
      private String lblTextblockhorasteoria1_Jsonclick ;
      private String edtavChorasteoria1_Jsonclick ;
      private String lblTextblockhoraspractica2_Internalname ;
      private String lblTextblockhoraspractica2_Jsonclick ;
      private String edtavChoraspractica2_Jsonclick ;
      private String lblTextblockhoraslaboratorio3_Internalname ;
      private String lblTextblockhoraslaboratorio3_Jsonclick ;
      private String edtavChoraslaboratorio3_Jsonclick ;
      private String GXt_char8 ;
      private String ROClassString ;
      private String edtAsignaturaId_Jsonclick ;
      private String edtAsignaturaNombre_Jsonclick ;
      private String edtCreditos_Jsonclick ;
      private String edtSemestre_Jsonclick ;
      private String edtHorasTeoria1_Jsonclick ;
      private String edtHorasPractica2_Jsonclick ;
      private String edtHorasLaboratorio3_Jsonclick ;
      private String GXt_char9 ;
      private bool entryPointCalled ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool returnInSub ;
      private String AV7cAsignaturaNombre ;
      private String A23AsignaturaNombre ;
      private String lV7cAsignaturaNombre ;
      private String AV5LinkSelection ;
      private GXMasterPage MasterPageObj ;
      private GXWebGrid Grid1Container ;
      private GXWebRow Grid1Row ;
      private GXWebColumn Grid1Column ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] H000C2_A41HorasLaboratorio3 ;
      private short[] H000C2_A40HorasPractica2 ;
      private short[] H000C2_A39HorasTeoria1 ;
      private short[] H000C2_A35Semestre ;
      private short[] H000C2_A34Creditos ;
      private String[] H000C2_A23AsignaturaNombre ;
      private short[] H000C2_A22AsignaturaId ;
      private int[] H000C3_AGRID1_nRecordCount ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      private short aP0_pAsignaturaId ;
      private GXWebForm Form ;
   }

   public class gx00a0__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmH000C2 ;
          prmH000C2 = new Object[] {
          new Object[] {"@AV6cAsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cAsignaturaNombre",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV9cCreditos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cSemestre",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14cHorasTeoria1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15cHorasPractica2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV16cHorasLaboratorio3",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmH000C3 ;
          prmH000C3 = new Object[] {
          new Object[] {"@AV6cAsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@lV7cAsignaturaNombre",SqlDbType.VarChar,60,0} ,
          new Object[] {"@AV9cCreditos",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV10cSemestre",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV14cHorasTeoria1",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV15cHorasPractica2",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV16cHorasLaboratorio3",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("H000C2", "SELECT [HorasLaboratorio3], [HorasPractica2], [HorasTeoria1], [Semestre], [Creditos], [AsignaturaNombre], [AsignaturaId] FROM [Asignatura] WITH (NOLOCK) WHERE ([AsignaturaId] >= @AV6cAsignaturaId) AND ([AsignaturaNombre] like @lV7cAsignaturaNombre) AND ([Creditos] >= @AV9cCreditos) AND ([Semestre] >= @AV10cSemestre) AND ([HorasTeoria1] >= @AV14cHorasTeoria1) AND ([HorasPractica2] >= @AV15cHorasPractica2) AND ([HorasLaboratorio3] >= @AV16cHorasLaboratorio3) ORDER BY [AsignaturaId]  OPTION (FAST 11)",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C2,11,0,false,false )
             ,new CursorDef("H000C3", "SELECT COUNT(*) FROM [Asignatura] WITH (NOLOCK) WHERE ([AsignaturaId] >= @AV6cAsignaturaId) AND ([AsignaturaNombre] like @lV7cAsignaturaNombre) AND ([Creditos] >= @AV9cCreditos) AND ([Semestre] >= @AV10cSemestre) AND ([HorasTeoria1] >= @AV14cHorasTeoria1) AND ([HorasPractica2] >= @AV15cHorasPractica2) AND ([HorasLaboratorio3] >= @AV16cHorasLaboratorio3) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmH000C3,1,0,false,false )
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
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                break;
       }
    }

 }

}
