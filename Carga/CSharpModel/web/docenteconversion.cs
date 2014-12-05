/*
               File: DocenteConversion
        Description: Conversion for table Docente
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 12/3/2014 4:37:9.15
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
   public class docenteconversion : GXProcedure
   {
      public docenteconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public docenteconversion( IGxContext context )
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
         docenteconversion objdocenteconversion;
         objdocenteconversion = new docenteconversion();
         objdocenteconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objdocenteconversion.executePrivateCatch ));
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0014] ON "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
         /* Using cursor DOCENTECON2 */
         pr_default.execute(0);
         while ( (pr_default.getStatus(0) != 101) )
         {
            A5DocenteNombres = DOCENTECON2_A5DocenteNombres[0] ;
            A4DocenteId = DOCENTECON2_A4DocenteId[0] ;
            AV5GXV7 = 0 ;
            /* Using cursor DOCENTECON3 */
            pr_default.execute(1, new Object[] {A4DocenteId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A7CategoriaId = DOCENTECON3_A7CategoriaId[0] ;
               A18CargaLectivaId = DOCENTECON3_A18CargaLectivaId[0] ;
               A42CargaDetalleId = DOCENTECON3_A42CargaDetalleId[0] ;
               AV5GXV7 = A7CategoriaId ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /*
               INSERT RECORD ON TABLE GXA0014

            */
            AV2DocenteId = A4DocenteId ;
            AV3DocenteNombres = A5DocenteNombres ;
            AV4CategoriaId = 0 ;
            /* Using cursor DOCENTECON4 */
            pr_default.execute(2, new Object[] {AV2DocenteId, AV3DocenteNombres, AV4CategoriaId});
            pr_default.close(2);
            if ( (pr_default.getStatus(2) == 1) )
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
         cmdBuffer=" SET IDENTITY_INSERT [GXA0014] OFF "
         ;
         RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
         RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
         RGZ.ExecuteStmt() ;
         RGZ.Drop();
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
         cmdBuffer = "" ;
         scmdbuf = "" ;
         DOCENTECON2_A5DocenteNombres = new String[] {""} ;
         DOCENTECON2_A4DocenteId = new short[1] ;
         A5DocenteNombres = "" ;
         DOCENTECON3_A4DocenteId = new short[1] ;
         DOCENTECON3_A7CategoriaId = new short[1] ;
         DOCENTECON3_A18CargaLectivaId = new short[1] ;
         DOCENTECON3_A42CargaDetalleId = new short[1] ;
         AV3DocenteNombres = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.docenteconversion__default(),
            new Object[][] {
                new Object[] {
               DOCENTECON2_A5DocenteNombres, DOCENTECON2_A4DocenteId
               }
               , new Object[] {
               DOCENTECON3_A4DocenteId, DOCENTECON3_A7CategoriaId, DOCENTECON3_A18CargaLectivaId, DOCENTECON3_A42CargaDetalleId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A4DocenteId ;
      private short AV5GXV7 ;
      private short A7CategoriaId ;
      private short A18CargaLectivaId ;
      private short A42CargaDetalleId ;
      private short AV2DocenteId ;
      private short AV4CategoriaId ;
      private int GIGXA0014 ;
      private String cmdBuffer ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A5DocenteNombres ;
      private String AV3DocenteNombres ;
      private IGxDataStore dsDefault ;
      private GxCommand RGZ ;
      private IDataStoreProvider pr_default ;
      private String[] DOCENTECON2_A5DocenteNombres ;
      private short[] DOCENTECON2_A4DocenteId ;
      private short[] DOCENTECON3_A4DocenteId ;
      private short[] DOCENTECON3_A7CategoriaId ;
      private short[] DOCENTECON3_A18CargaLectivaId ;
      private short[] DOCENTECON3_A42CargaDetalleId ;
   }

   public class docenteconversion__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new UpdateCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmDOCENTECON2 ;
          prmDOCENTECON2 = new Object[] {
          } ;
          Object[] prmDOCENTECON3 ;
          prmDOCENTECON3 = new Object[] {
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmDOCENTECON4 ;
          prmDOCENTECON4 = new Object[] {
          new Object[] {"@AV2DocenteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3DocenteNombres",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV4CategoriaId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("DOCENTECON2", "SELECT [DocenteNombres], [DocenteId] FROM [Docente] ORDER BY [DocenteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmDOCENTECON2,100,0,true,false )
             ,new CursorDef("DOCENTECON3", "SELECT TOP 1 [DocenteId], [CategoriaId], [CargaLectivaId], [CargaDetalleId] FROM [CargaLectivaCargaDetalle] WHERE [DocenteId] = @DocenteId ORDER BY [DocenteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmDOCENTECON3,1,0,false,true )
             ,new CursorDef("DOCENTECON4", "INSERT INTO [GXA0014] ([DocenteId], [DocenteNombres], [CategoriaId]) VALUES (@AV2DocenteId, @AV3DocenteNombres, @AV4CategoriaId)", GxErrorMask.GX_NOMASK,prmDOCENTECON4)
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
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
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
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                break;
       }
    }

 }

}
