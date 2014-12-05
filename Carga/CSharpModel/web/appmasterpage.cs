/*
               File: AppMasterPage
        Description: Application Master
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 12/3/2014 8:48:44.33
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
   public class appmasterpage : GXMasterPage, System.Web.SessionState.IRequiresSessionState
   {
      public appmasterpage( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
         context.SetTheme("Modern");
      }

      public appmasterpage( IGxContext context )
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

      protected void INITWEB( )
      {
         initialize_properties( ) ;
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
            PA012( ) ;
            if ( ( GxWebError == 0 ) && ! isAjaxCallMode( ) )
            {
               /* GeneXus formulas. */
               context.Gx_err = 0 ;
               WS012( ) ;
               if ( ! isAjaxCallMode( ) )
               {
                  WE012( ) ;
               }
            }
         }
         this.cleanup();
      }

      protected void RenderHtmlHeaders( )
      {
         getDataAreaObject().RenderHtmlHeaders();
      }

      protected void RenderHtmlOpenForm( )
      {
         getDataAreaObject().RenderHtmlOpenForm();
      }

      protected void RenderHtmlCloseForm012( )
      {
         /* Send hidden variables. */
         /* Send saved values. */
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vMENUDATA_MPAGE", (Object)(AV6MenuData));
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vMENUDATA_MPAGE", (Object)(AV6MenuData));
         }
         if ( context.isAjaxRequest( ) )
         {
            context.httpAjaxContext.ajax_rsp_assign_sdt_attri("", true, "vMENUDATAITEM_MPAGE", (Object)(AV7MenuDataItem));
         }
         else
         {
            context.httpAjaxContext.ajax_rsp_assign_hidden_sdt("vMENUDATAITEM_MPAGE", (Object)(AV7MenuDataItem));
         }
         getDataAreaObject().RenderHtmlCloseForm();
         context.AddJavascriptSource("DolphinStyleMenu/dolphin.js", "");
         context.AddJavascriptSource("DolphinStyleMenu/DolphinStyleMenuRender.js", "");
         context.AddJavascriptSource("appmasterpage.js", "?8484434");
         context.WriteHtmlTextNl( "</body>") ;
         context.WriteHtmlTextNl( "</html>") ;
      }

      protected void WB010( )
      {
         if ( context.isAjaxRequest( ) )
         {
            disableOutput();
         }
         if ( ! wbLoad )
         {
            RenderHtmlHeaders( ) ;
            RenderHtmlOpenForm( ) ;
            if ( ! ShowMPWhenPopUp( ) && context.isPopUpObject( ) )
            {
               getDataAreaObject().RenderHtmlContent();
               return  ;
            }
            wb_table1_2_012( true) ;
         }
         else
         {
            wb_table1_2_012( false) ;
         }
         return  ;
      }

      protected void wb_table1_2_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "<p></p>") ;
         }
         wbLoad = true ;
      }

      protected void START012( )
      {
         wbLoad = false ;
         wbEnd = 0 ;
         wbStart = 0 ;
         context.wjLoc = "" ;
         context.nUserReturn = 0 ;
         context.wbHandled = 0 ;
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
         }
         wbErr = false ;
         STRUP010( ) ;
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            if ( getDataAreaObject().ExecuteStartEvent() != 0 )
            {
               setAjaxCallMode();
            }
         }
      }

      protected void WS012( )
      {
         START012( ) ;
         EVT012( ) ;
      }

      protected void EVT012( )
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
                  if ( StringUtil.StrCmp(sEvtType, "E") == 0 )
                  {
                     sEvtType = StringUtil.Right( sEvt, 1) ;
                     if ( StringUtil.StrCmp(sEvtType, ".") == 0 )
                     {
                        sEvt = StringUtil.Left( sEvt, (short)(StringUtil.Len( sEvt)-1)) ;
                        if ( StringUtil.StrCmp(sEvt, "RFR_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                        }
                        else if ( StringUtil.StrCmp(sEvt, "START_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E11012 */
                           E11012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "REFRESH_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E12012 */
                           E12012 ();
                        }
                        else if ( StringUtil.StrCmp(sEvt, "ENTER_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           if ( ! wbErr )
                           {
                              Rfr0gs = false ;
                              if ( ! Rfr0gs )
                              {
                                 /* Execute user event: E13012 */
                                 E13012 ();
                              }
                              dynload_actions( ) ;
                           }
                        }
                        else if ( StringUtil.StrCmp(sEvt, "LOAD_MPAGE") == 0 )
                        {
                           context.wbHandled = 1 ;
                           dynload_actions( ) ;
                           /* Execute user event: E14012 */
                           E14012 ();
                           /* No code required for Cancel button. It is implemented as the Reset button. */
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
                  if ( context.wbHandled == 0 )
                  {
                     getDataAreaObject().DispatchEvents();
                  }
                  context.wbHandled = 1 ;
               }
            }
         }
      }

      protected void WE012( )
      {
         if ( ! GxWebStd.gx_redirect( context) )
         {
            Rfr0gs = true ;
            Refresh( ) ;
            if ( ! GxWebStd.gx_redirect( context) )
            {
               RenderHtmlCloseForm012( ) ;
            }
         }
      }

      protected void PA012( )
      {
         if ( nDonePA == 0 )
         {
            nDonePA = 1 ;
         }
      }

      protected void dynload_actions( )
      {
         /* End function dynload_actions */
      }

      protected void Refresh( )
      {
         RF012( ) ;
         /* End function Refresh */
      }

      protected void RF012( )
      {
         /* Execute user event: E12012 */
         E12012 ();
         if ( String.IsNullOrEmpty(StringUtil.RTrim( context.wjLoc)) && ( context.nUserReturn != 1 ) )
         {
            /* Execute user event: E14012 */
            E14012 ();
            WB010( ) ;
         }
      }

      protected void STRUP010( )
      {
         /* Before Start, stand alone formulas. */
         context.Gx_err = 0 ;
         /* Execute Start event if defined. */
         context.wbGlbDoneStart = 0 ;
         /* Execute user event: E11012 */
         E11012 ();
         context.wbGlbDoneStart = 1 ;
         /* After Start, stand alone formulas. */
         if ( StringUtil.StrCmp(context.GetRequestMethod( ), "POST") == 0 )
         {
            /* Read saved SDTs. */
            ajax_req_read_hidden_sdt(cgiGet( "vMENUDATA_MPAGE"), (Object)(AV6MenuData));
            ajax_req_read_hidden_sdt(cgiGet( "vMENUDATAITEM_MPAGE"), (Object)(AV7MenuDataItem));
            /* Read variables values. */
            /* Read saved values. */
            Dolphinstylemenu1_Width = cgiGet( "DOLPHINSTYLEMENU1_MPAGE_Width") ;
            Dolphinstylemenu1_Height = cgiGet( "DOLPHINSTYLEMENU1_MPAGE_Height") ;
            Dolphinstylemenu1_Visible = StringUtil.StrToBool( cgiGet( "DOLPHINSTYLEMENU1_MPAGE_Visible")) ;
            /* Read subfile selected row values. */
            /* Read hidden variables. */
         }
         else
         {
            dynload_actions( ) ;
         }
      }

      protected void S112( )
      {
         /* 'DOLPHINSTYLEMENUSAMPLE' Routine */
         GXt_objcol_SdtMenuData_MenuDataItem1 = AV6MenuData ;
         new dpdolphinmenudata(context ).execute( out  GXt_objcol_SdtMenuData_MenuDataItem1) ;
         AV6MenuData = GXt_objcol_SdtMenuData_MenuDataItem1 ;
      }

      protected void GXStart( )
      {
         /* Execute user event: E11012 */
         E11012 ();
         if (returnInSub) return;
      }

      protected void E11012( )
      {
         /* Start Routine */
         /* Execute user subroutine: S112 */
         S112 ();
         if (returnInSub) return;
      }

      protected void E12012( )
      {
         /* Refresh Routine */
      }

      public void GXEnter( )
      {
         /* Execute user event: E13012 */
         E13012 ();
         if (returnInSub) return;
      }

      protected void E13012( )
      {
         /* Enter Routine */
      }

      protected void nextLoad( )
      {
      }

      protected void E14012( )
      {
         /* Load Routine */
      }

      protected void wb_table1_2_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable4_Internalname, tblTable4_Internalname, "", "Table95", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            wb_table2_5_012( true) ;
         }
         else
         {
            wb_table2_5_012( false) ;
         }
         return  ;
      }

      protected void wb_table2_5_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table3_12_012( true) ;
         }
         else
         {
            wb_table3_12_012( false) ;
         }
         return  ;
      }

      protected void wb_table3_12_012e( bool wbgen )
      {
         if ( wbgen )
         {
            /* User Defined Control */
            context.WriteHtmlText( "<div class=\"gx_usercontrol\" id=\""+"MPDOLPHINSTYLEMENU1Container"+"\"></div>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\"  style=\"height:14px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td style=\"height:34px;width:0px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:100%\">") ;
            wb_table4_19_012( true) ;
         }
         else
         {
            wb_table4_19_012( false) ;
         }
         return  ;
      }

      protected void wb_table4_19_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"width:0px\">") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td colspan=\"3\" >") ;
            wb_table5_26_012( true) ;
         }
         else
         {
            wb_table5_26_012( false) ;
         }
         return  ;
      }

      protected void wb_table5_26_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table6_29_012( true) ;
         }
         else
         {
            wb_table6_29_012( false) ;
         }
         return  ;
      }

      protected void wb_table6_29_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table7_32_012( true) ;
         }
         else
         {
            wb_table7_32_012( false) ;
         }
         return  ;
      }

      protected void wb_table7_32_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table8_35_012( true) ;
         }
         else
         {
            wb_table8_35_012( false) ;
         }
         return  ;
      }

      protected void wb_table8_35_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table9_39_012( true) ;
         }
         else
         {
            wb_table9_39_012( false) ;
         }
         return  ;
      }

      protected void wb_table9_39_012e( bool wbgen )
      {
         if ( wbgen )
         {
            wb_table10_42_012( true) ;
         }
         else
         {
            wb_table10_42_012( false) ;
         }
         return  ;
      }

      protected void wb_table10_42_012e( bool wbgen )
      {
         if ( wbgen )
         {
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table1_2_012e( true) ;
         }
         else
         {
            wb_table1_2_012e( false) ;
         }
      }

      protected void wb_table10_42_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable10_Internalname, tblTable10_Internalname, "", "HorizontalLine", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table10_42_012e( true) ;
         }
         else
         {
            wb_table10_42_012e( false) ;
         }
      }

      protected void wb_table9_39_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable9_Internalname, tblTable9_Internalname, "", "HorizontalSpace", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table9_39_012e( true) ;
         }
         else
         {
            wb_table9_39_012e( false) ;
         }
      }

      protected void wb_table8_35_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable3_Internalname, tblTable3_Internalname, "", "TableBottom", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr align=\"left\" >") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "center")+"\">") ;
            /* Text block */
            ClassString = "SmallText" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblock1_Internalname, "EPIS - UNSA 2014", "", "", lblTextblock1_Jsonclick, "E_MPAGE.", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table8_35_012e( true) ;
         }
         else
         {
            wb_table8_35_012e( false) ;
         }
      }

      protected void wb_table7_32_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable8_Internalname, tblTable8_Internalname, "", "HorizontalSpace", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table7_32_012e( true) ;
         }
         else
         {
            wb_table7_32_012e( false) ;
         }
      }

      protected void wb_table6_29_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable7_Internalname, tblTable7_Internalname, "", "HorizontalLine", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table6_29_012e( true) ;
         }
         else
         {
            wb_table6_29_012e( false) ;
         }
      }

      protected void wb_table5_26_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable6_Internalname, tblTable6_Internalname, "", "HorizontalSpace", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table5_26_012e( true) ;
         }
         else
         {
            wb_table5_26_012e( false) ;
         }
      }

      protected void wb_table4_19_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable5_Internalname, tblTable5_Internalname, "", "ViewTable", 0, "", "", 1, 2, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            getDataAreaObject().RenderHtmlContent();
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table4_19_012e( true) ;
         }
         else
         {
            wb_table4_19_012e( false) ;
         }
      }

      protected void wb_table3_12_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            sStyleString = sStyleString + " width: " + StringUtil.LTrim( StringUtil.Str( (decimal)(100), 10, 0)) + "%" + ";" ;
            GxWebStd.gx_table_start( context, tblTable2_Internalname, tblTable2_Internalname, "", "TableTopMenu", 0, "", "", 1, 2, sStyleString, "none", 0);
            context.WriteHtmlText( "<tbody></tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table3_12_012e( true) ;
         }
         else
         {
            wb_table3_12_012e( false) ;
         }
      }

      protected void wb_table2_5_012( bool wbgen )
      {
         if ( wbgen )
         {
            /* Table start */
            sStyleString = "" ;
            GxWebStd.gx_table_start( context, tblTable1_Internalname, tblTable1_Internalname, "", "TableTop", 0, "", "", 0, 0, sStyleString, "", 0);
            context.WriteHtmlText( "<tbody>") ;
            context.WriteHtmlText( "<tr>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td>") ;
            context.WriteHtmlText( "&nbsp; ") ;
            /* Text block */
            ClassString = "TextBlockHeader" ;
            StyleString = "" ;
            GxWebStd.gx_label_ctrl( context, lblTextblockheader1_Internalname, "Sistema de Carga Lectiva 2014", "", "", lblTextblockheader1_Jsonclick, "E_MPAGE.", StyleString, ClassString, 0, "", 1, 1, 0, "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "<td style=\"text-align:"+context.GetCssProperty( "Align", "right")+"\">") ;
            /* Static images/pictures */
            ClassString = "HeaderImage1" ;
            StyleString = "" ;
            GxWebStd.gx_bitmap( context, imgImage1_Internalname, context.GetImagePath( "7326b96a-20b7-4973-8d71-35094049767d", "", "Modern"), "", "", "", "Modern", 1, 1, "", "", 0, 0, 0, "", 0, "", 0, 0, 0, "", "", StyleString, ClassString, "", "", "", "", "HLP_AppMasterPage.htm");
            context.WriteHtmlText( "</td>") ;
            context.WriteHtmlText( "</tr>") ;
            context.WriteHtmlText( "</tbody>") ;
            /* End of table */
            context.WriteHtmlText( "</table>") ;
            wb_table2_5_012e( true) ;
         }
         else
         {
            wb_table2_5_012e( false) ;
         }
      }

      public override void setparameters( Object[] obj )
      {
         createObjects();
         initialize();
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
         PA012( ) ;
         WS012( ) ;
         WE012( ) ;
         this.cleanup();
         context.SetWrapped(false);
         context.GX_msglist = BackMsgLst ;
         return "";
      }

      public void responsestatic( String sGXDynURL )
      {
      }

      public override void master_styles( )
      {
         define_styles( ) ;
      }

      protected void define_styles( )
      {
         AddStyleSheetFile("DolphinStyleMenu/dolphin.css", "?224400");
         AddThemeStyleSheetFile("", "Modern.css", "?1844366");
         idxLst = 1 ;
         while ( idxLst <= getDataAreaObject().GetForm().Jscriptsrc.Count )
         {
            context.AddJavascriptSource(StringUtil.RTrim( getDataAreaObject().GetForm().Jscriptsrc.Item(idxLst)), "?8484445");
            idxLst = (int)(idxLst+1) ;
         }
         /* End function define_styles */
      }

      protected void include_jscripts( )
      {
         context.AddJavascriptSource("appmasterpage.js", "?8484445");
         context.AddJavascriptSource("DolphinStyleMenu/dolphin.js", "");
         context.AddJavascriptSource("DolphinStyleMenu/DolphinStyleMenuRender.js", "");
         /* End function include_jscripts */
      }

      protected void init_default_properties( )
      {
         lblTextblockheader1_Internalname = "TEXTBLOCKHEADER1_MPAGE" ;
         imgImage1_Internalname = "IMAGE1_MPAGE" ;
         tblTable1_Internalname = "TABLE1_MPAGE" ;
         tblTable2_Internalname = "TABLE2_MPAGE" ;
         Dolphinstylemenu1_Internalname = "DOLPHINSTYLEMENU1_MPAGE" ;
         tblTable5_Internalname = "TABLE5_MPAGE" ;
         tblTable6_Internalname = "TABLE6_MPAGE" ;
         tblTable7_Internalname = "TABLE7_MPAGE" ;
         tblTable8_Internalname = "TABLE8_MPAGE" ;
         lblTextblock1_Internalname = "TEXTBLOCK1_MPAGE" ;
         tblTable3_Internalname = "TABLE3_MPAGE" ;
         tblTable9_Internalname = "TABLE9_MPAGE" ;
         tblTable10_Internalname = "TABLE10_MPAGE" ;
         tblTable4_Internalname = "TABLE4_MPAGE" ;
         getDataAreaObject().GetForm().Internalname = "FORM_MPAGE" ;
      }

      protected void initialize_properties( )
      {
         init_default_properties( ) ;
         Contentholder.setDataArea(getDataAreaObject());
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
         Contentholder = new GXDataAreaControl();
         AV6MenuData = new GxObjectCollection( context, "MenuData.MenuDataItem", "Carga", "SdtMenuData_MenuDataItem", "GeneXus.Programs");
         AV7MenuDataItem = new SdtMenuData_MenuDataItem(context);
         sPrefix = "" ;
         sEvt = "" ;
         EvtGridId = "" ;
         EvtRowId = "" ;
         sEvtType = "" ;
         Dolphinstylemenu1_Width = "" ;
         Dolphinstylemenu1_Height = "" ;
         GXt_objcol_SdtMenuData_MenuDataItem1 = new GxObjectCollection( context, "MenuData.MenuDataItem", "Carga", "SdtMenuData_MenuDataItem", "GeneXus.Programs");
         sStyleString = "" ;
         ClassString = "" ;
         StyleString = "" ;
         lblTextblock1_Jsonclick = "" ;
         lblTextblockheader1_Jsonclick = "" ;
         GXt_char2 = "" ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         sDynURL = "" ;
         Form = new GXWebForm();
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short initialized ;
      private short GxWebError ;
      private short wbEnd ;
      private short wbStart ;
      private short nDonePA ;
      private short nGotPars ;
      private short nGXWrapped ;
      private int idxLst ;
      private String sPrefix ;
      private String sEvt ;
      private String EvtGridId ;
      private String EvtRowId ;
      private String sEvtType ;
      private String Dolphinstylemenu1_Width ;
      private String Dolphinstylemenu1_Height ;
      private String sStyleString ;
      private String tblTable4_Internalname ;
      private String tblTable10_Internalname ;
      private String tblTable9_Internalname ;
      private String tblTable3_Internalname ;
      private String ClassString ;
      private String StyleString ;
      private String lblTextblock1_Internalname ;
      private String lblTextblock1_Jsonclick ;
      private String tblTable8_Internalname ;
      private String tblTable7_Internalname ;
      private String tblTable6_Internalname ;
      private String tblTable5_Internalname ;
      private String tblTable2_Internalname ;
      private String tblTable1_Internalname ;
      private String lblTextblockheader1_Internalname ;
      private String lblTextblockheader1_Jsonclick ;
      private String GXt_char2 ;
      private String imgImage1_Internalname ;
      private String sDynURL ;
      private String Dolphinstylemenu1_Internalname ;
      private bool wbLoad ;
      private bool Rfr0gs ;
      private bool wbErr ;
      private bool Dolphinstylemenu1_Visible ;
      private bool returnInSub ;
      private IGxDataStore dsDefault ;
      private GXDataAreaControl Contentholder ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
      [ObjectCollection(ItemType=typeof( SdtMenuData_MenuDataItem ))]
      private IGxCollection AV6MenuData ;
      [ObjectCollection(ItemType=typeof( SdtMenuData_MenuDataItem ))]
      private IGxCollection GXt_objcol_SdtMenuData_MenuDataItem1 ;
      private GXWebForm Form ;
      private SdtMenuData_MenuDataItem AV7MenuDataItem ;
   }

}
