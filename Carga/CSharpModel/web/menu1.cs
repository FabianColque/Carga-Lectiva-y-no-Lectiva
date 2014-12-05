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
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class menu1
   {
      public menu1( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
      }

      public menu1( IGxContext context )
      {
      }

      public void execute( )
      {
         executePrivate();
      }

      void executePrivate( )
      {
         GXUtil.Msg( "Object not currently supported mnu - Menu1" );
      }

      public override void webExecute( )
      {
         context.WriteHtmlText( "Object not currently supported mnu - Menu1") ;
      }

      public override void initialize( )
      {
      }

      protected override void createObjects( )
      {
      }

   }

}
