/*
               File: CargaLectivaConversion
        Description: Conversion for table CargaLectiva
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 9/28/2014 20:17:55.72
       Program type: Callable routine
          Main DBMS: sqlserver
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
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
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.Data.SqlTypes;
namespace GeneXus.Programs {
   public class cargalectivaconversion : GXProcedure
   {
      public cargalectivaconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cargalectivaconversion( IGxContext context )
      {
         this.DisconnectAtCleanup = true;
         context = context.UtlClone();
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default") ;
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      public void executeSubmit( )
      {
         cargalectivaconversion objcargalectivaconversion;
         objcargalectivaconversion = new cargalectivaconversion();
         objcargalectivaconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objcargalectivaconversion.executePrivateCatch ));
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
         /* Using cursor CARGALECTI2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A18CargaLectivaId = CARGALECTI2_A18CargaLectivaId[0] ;
            A19CargaLectivaFecha = CARGALECTI2_A19CargaLectivaFecha[0] ;
            A40000GXC1 = CARGALECTI2_A40000GXC1[0] ;
            /*
               INSERT RECORD ON TABLE GXA0006

            */
            AV2CargaLectivaId = A18CargaLectivaId ;
            AV3CargaLectivaFecha = A40000GXC1 ;
            /* Using cursor CARGALECTI3 */
            pr_default.execute(1, new Object[] {AV2CargaLectivaId, AV3CargaLectivaFecha});
            pr_default.close(1);
            if ( (pr_default.getStatus(1) == 1) )
            {
               context.Gx_err = 1 ;
               Gx_emsg = (String)(GXResourceManager.GetMessage("GXM_noupdate")) ;
            }
            else
            {
               context.Gx_err = 0 ;
               Gx_emsg = "" ;
            }
            /* End Insert */
            pr_default.readNext(0);
         }
         pr_default.close(0);
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
         scmdbuf = "" ;
         CARGALECTI2_A18CargaLectivaId = new short[1] ;
         CARGALECTI2_A19CargaLectivaFecha = new short[1] ;
         CARGALECTI2_A40000GXC1 = new DateTime[] {DateTime.MinValue} ;
         A40000GXC1 = (DateTime)(DateTime.MinValue) ;
         AV3CargaLectivaFecha = (DateTime)(DateTime.MinValue) ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cargalectivaconversion__default(),
            new Object[][] {
                new Object[] {
               CARGALECTI2_A18CargaLectivaId, CARGALECTI2_A19CargaLectivaFecha, CARGALECTI2_A40000GXC1
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A18CargaLectivaId ;
      private short A19CargaLectivaFecha ;
      private short AV2CargaLectivaId ;
      private int GIGXA0006 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private DateTime A40000GXC1 ;
      private DateTime AV3CargaLectivaFecha ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] CARGALECTI2_A18CargaLectivaId ;
      private short[] CARGALECTI2_A19CargaLectivaFecha ;
      private DateTime[] CARGALECTI2_A40000GXC1 ;
   }

   public class cargalectivaconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new UpdateCursor(def[1])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmCARGALECTI2 ;
          prmCARGALECTI2 = new Object[] {
          } ;
          Object[] prmCARGALECTI3 ;
          prmCARGALECTI3 = new Object[] {
          new Object[] {"@AV2CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3CargaLectivaFecha",SqlDbType.DateTime,8,5}
          } ;
          def= new CursorDef[] {
              new CursorDef("CARGALECTI2", "SELECT [CargaLectivaId], [CargaLectivaFecha], convert(int, 0) AS GXC1 FROM [CargaLectiva] ORDER BY [CargaLectivaId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCARGALECTI2,100,0,true,false )
             ,new CursorDef("CARGALECTI3", "INSERT INTO [GXA0006] ([CargaLectivaId], [CargaLectivaFecha]) VALUES (@AV2CargaLectivaId, @AV3CargaLectivaFecha)", GxErrorMask.GX_NOMASK,prmCARGALECTI3)
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
                ((DateTime[]) buf[2])[0] = rslt.getGXDateTime(3) ;
                break;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (DateTime)parms[1]);
                break;
       }
    }

 }

}
