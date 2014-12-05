using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   [Serializable]
   public class SdtMenuData2 : GxUserType
   {
      public SdtMenuData2( )
      {
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public SdtMenuData2( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly() ;
         initialize();
      }

      public override short readxml( GXXMLReader oReader ,
                                     String sName )
      {
         short GXSoapError = 1 ;
         sTagName = oReader.Name ;
         if ( oReader.IsSimple == 0 )
         {
            GXSoapError = oReader.Read() ;
            nOutParmCount = 0 ;
            while ( ( ( StringUtil.StrCmp(oReader.Name, sTagName) != 0 ) || ( oReader.NodeType == 1 ) ) && ( GXSoapError > 0 ) )
            {
               readOk = 0 ;
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuId") == 0 )
               {
                  gxTv_SdtMenuData2_Menuid = (short)(NumberUtil.Val( oReader.Value, ".")) ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuTitle") == 0 )
               {
                  gxTv_SdtMenuData2_Menutitle = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuDescription") == 0 )
               {
                  gxTv_SdtMenuData2_Menudescription = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               if ( StringUtil.StrCmp(oReader.LocalName, "MenuURL") == 0 )
               {
                  gxTv_SdtMenuData2_Menuurl = oReader.Value ;
                  if ( GXSoapError > 0 )
                  {
                     readOk = 1 ;
                  }
                  GXSoapError = oReader.Read() ;
               }
               nOutParmCount = (short)(nOutParmCount+1) ;
               if ( readOk == 0 )
               {
                  context.sSOAPErrMsg = context.sSOAPErrMsg + "Error reading " + sTagName + StringUtil.NewLine( ) ;
                  GXSoapError = (short)(nOutParmCount*-1) ;
               }
            }
         }
         return GXSoapError ;
      }

      public override void writexml( GXXMLWriter oWriter ,
                                     String sName ,
                                     String sNameSpace )
      {
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sName)) )
         {
            sName = "MenuData2" ;
         }
         if ( String.IsNullOrEmpty(StringUtil.RTrim( sNameSpace)) )
         {
            sNameSpace = "Carga" ;
         }
         oWriter.WriteStartElement(sName);
         if ( StringUtil.StrCmp(StringUtil.Left( sNameSpace, 10), "[*:nosend]") != 0 )
         {
            oWriter.WriteAttribute("xmlns", sNameSpace);
         }
         else
         {
            sNameSpace = StringUtil.Right( sNameSpace, (short)(StringUtil.Len( sNameSpace)-10)) ;
         }
         oWriter.WriteElement("MenuId", StringUtil.Trim( StringUtil.Str( (decimal)(gxTv_SdtMenuData2_Menuid), 4, 0)));
         if ( StringUtil.StrCmp(sNameSpace, "Carga") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Carga");
         }
         oWriter.WriteElement("MenuTitle", StringUtil.RTrim( gxTv_SdtMenuData2_Menutitle));
         if ( StringUtil.StrCmp(sNameSpace, "Carga") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Carga");
         }
         oWriter.WriteElement("MenuDescription", StringUtil.RTrim( gxTv_SdtMenuData2_Menudescription));
         if ( StringUtil.StrCmp(sNameSpace, "Carga") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Carga");
         }
         oWriter.WriteElement("MenuURL", StringUtil.RTrim( gxTv_SdtMenuData2_Menuurl));
         if ( StringUtil.StrCmp(sNameSpace, "Carga") != 0 )
         {
            oWriter.WriteAttribute("xmlns", "Carga");
         }
         oWriter.WriteEndElement();
         return  ;
      }

      public override void ToJSON( )
      {
         AddObjectProperty("MenuId", (Object)(gxTv_SdtMenuData2_Menuid));
         AddObjectProperty("MenuTitle", (Object)(gxTv_SdtMenuData2_Menutitle));
         AddObjectProperty("MenuDescription", (Object)(gxTv_SdtMenuData2_Menudescription));
         AddObjectProperty("MenuURL", (Object)(gxTv_SdtMenuData2_Menuurl));
         return  ;
      }

      public short gxTpr_Menuid
      {
         get {
            return gxTv_SdtMenuData2_Menuid ;
         }

         set {
            gxTv_SdtMenuData2_Menuid = (short)(value) ;
         }

      }

      public void gxTv_SdtMenuData2_Menuid_SetNull( )
      {
         gxTv_SdtMenuData2_Menuid = 0 ;
         return  ;
      }

      public bool gxTv_SdtMenuData2_Menuid_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Menutitle
      {
         get {
            return gxTv_SdtMenuData2_Menutitle ;
         }

         set {
            gxTv_SdtMenuData2_Menutitle = (String)(value) ;
         }

      }

      public void gxTv_SdtMenuData2_Menutitle_SetNull( )
      {
         gxTv_SdtMenuData2_Menutitle = "" ;
         return  ;
      }

      public bool gxTv_SdtMenuData2_Menutitle_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Menudescription
      {
         get {
            return gxTv_SdtMenuData2_Menudescription ;
         }

         set {
            gxTv_SdtMenuData2_Menudescription = (String)(value) ;
         }

      }

      public void gxTv_SdtMenuData2_Menudescription_SetNull( )
      {
         gxTv_SdtMenuData2_Menudescription = "" ;
         return  ;
      }

      public bool gxTv_SdtMenuData2_Menudescription_IsNull( )
      {
         return false ;
      }

      public String gxTpr_Menuurl
      {
         get {
            return gxTv_SdtMenuData2_Menuurl ;
         }

         set {
            gxTv_SdtMenuData2_Menuurl = (String)(value) ;
         }

      }

      public void gxTv_SdtMenuData2_Menuurl_SetNull( )
      {
         gxTv_SdtMenuData2_Menuurl = "" ;
         return  ;
      }

      public bool gxTv_SdtMenuData2_Menuurl_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtMenuData2_Menutitle = "" ;
         gxTv_SdtMenuData2_Menudescription = "" ;
         gxTv_SdtMenuData2_Menuurl = "" ;
         sTagName = "" ;
         return  ;
      }

      protected short gxTv_SdtMenuData2_Menuid ;
      protected short readOk ;
      protected short nOutParmCount ;
      protected String gxTv_SdtMenuData2_Menutitle ;
      protected String gxTv_SdtMenuData2_Menudescription ;
      protected String sTagName ;
      protected String gxTv_SdtMenuData2_Menuurl ;
      protected Assembly constructorCallingAssembly ;
      protected IGxContext context ;
   }

}
