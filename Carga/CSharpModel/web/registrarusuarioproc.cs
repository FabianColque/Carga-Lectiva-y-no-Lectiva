/*
               File: RegistrarUsuarioProc
        Description: Registrar Usuario Proc
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 12/3/2014 8:48:34.77
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
   public class registrarusuarioproc : GXProcedure
   {
      public registrarusuarioproc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetTheme("Modern");
      }

      public registrarusuarioproc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_UsuariosNombre ,
                           ref String aP1_UsuariosPassword )
      {
         this.A43UsuariosNombre = aP0_UsuariosNombre;
         this.A44UsuariosPassword = aP1_UsuariosPassword;
         initialize();
         executePrivate();
         aP0_UsuariosNombre=this.A43UsuariosNombre;
         aP1_UsuariosPassword=this.A44UsuariosPassword;
      }

      public String executeUdp( ref String aP0_UsuariosNombre )
      {
         this.A43UsuariosNombre = aP0_UsuariosNombre;
         this.A44UsuariosPassword = aP1_UsuariosPassword;
         initialize();
         executePrivate();
         aP0_UsuariosNombre=this.A43UsuariosNombre;
         aP1_UsuariosPassword=this.A44UsuariosPassword;
         return A44UsuariosPassword ;
      }

      public void executeSubmit( ref String aP0_UsuariosNombre ,
                                 ref String aP1_UsuariosPassword )
      {
         registrarusuarioproc objregistrarusuarioproc;
         objregistrarusuarioproc = new registrarusuarioproc();
         objregistrarusuarioproc.A43UsuariosNombre = aP0_UsuariosNombre;
         objregistrarusuarioproc.A44UsuariosPassword = aP1_UsuariosPassword;
         objregistrarusuarioproc.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objregistrarusuarioproc.executePrivateCatch ));
         aP0_UsuariosNombre=this.A43UsuariosNombre;
         aP1_UsuariosPassword=this.A44UsuariosPassword;
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
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private String A43UsuariosNombre ;
      private String A44UsuariosPassword ;
      private String aP0_UsuariosNombre ;
      private String aP1_UsuariosPassword ;
   }

}
