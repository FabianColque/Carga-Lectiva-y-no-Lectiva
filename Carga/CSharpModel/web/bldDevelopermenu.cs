using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0 ;
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\GeneXus.Programs.Common.rsp");
      return sc ;
   }

   public override ItemCollection GetRuntimeBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\main.dll", cs_path + @"\main.rsp");
      sc.Add( @"bin\gx00g0.dll", cs_path + @"\gx00g0.rsp");
      sc.Add( @"bin\registrarusuario.dll", cs_path + @"\registrarusuario.rsp");
      sc.Add( @"bin\gx00f1.dll", cs_path + @"\gx00f1.rsp");
      sc.Add( @"bin\gx00e0.dll", cs_path + @"\gx00e0.rsp");
      sc.Add( @"bin\gx00a0.dll", cs_path + @"\gx00a0.rsp");
      sc.Add( @"bin\gx0050.dll", cs_path + @"\gx0050.rsp");
      sc.Add( @"bin\gx0040.dll", cs_path + @"\gx0040.rsp");
      sc.Add( @"bin\gx0060.dll", cs_path + @"\gx0060.rsp");
      sc.Add( @"bin\promptmasterpage.dll", cs_path + @"\promptmasterpage.rsp");
      sc.Add( @"bin\recentlinks.dll", cs_path + @"\recentlinks.rsp");
      sc.Add( @"bin\appmasterpage.dll", cs_path + @"\appmasterpage.rsp");
      sc.Add( @"bin\usuarios.dll", cs_path + @"\usuarios.rsp");
      sc.Add( @"bin\docente.dll", cs_path + @"\docente.rsp");
      sc.Add( @"bin\asignatura.dll", cs_path + @"\asignatura.rsp");
      sc.Add( @"bin\escuela.dll", cs_path + @"\escuela.rsp");
      sc.Add( @"bin\categoria.dll", cs_path + @"\categoria.rsp");
      sc.Add( @"bin\cargalectiva.dll", cs_path + @"\cargalectiva.rsp");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.spa.dll", cs_path + @"\messages.spa.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\type_SdtLinkList_LinkItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMenuData_MenuDataItem.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtMenuData2.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxSilentTrnGridCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINRecentLinksOptions.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINMessageTypes.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINIMEMode.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.spa.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.spa.txt" ))
            return true;
      }
      return false ;
   }

}

