/*
               File: CargaLectivaDocenteConversion
        Description: Conversion for table CargaLectivaDocente
             Author: GeneXus C# Generator version 10_1_7-53786
       Generated on: 9/28/2014 23:38:25.46
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
   public class cargalectivadocenteconversion : GXProcedure
   {
      public cargalectivadocenteconversion( )
      {
         this.DisconnectAtCleanup = true;
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default") ;
         IsMain = true;
      }

      public cargalectivadocenteconversion( IGxContext context )
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
         cargalectivadocenteconversion objcargalectivadocenteconversion;
         objcargalectivadocenteconversion = new cargalectivadocenteconversion();
         objcargalectivadocenteconversion.initialize();
         ThreadPool.QueueUserWorkItem( new WaitCallback( objcargalectivadocenteconversion.executePrivateCatch ));
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
            A25Observacion = CARGALECTI2_A25Observacion[0] ;
            A11EscuelaId = CARGALECTI2_A11EscuelaId[0] ;
            A7CategoriaId = CARGALECTI2_A7CategoriaId[0] ;
            A22AsignaturaId = CARGALECTI2_A22AsignaturaId[0] ;
            A5DocenteNombres = CARGALECTI2_A5DocenteNombres[0] ;
            A4DocenteId = CARGALECTI2_A4DocenteId[0] ;
            A18CargaLectivaId = CARGALECTI2_A18CargaLectivaId[0] ;
            AV16GXV27 = "" ;
            AV15GXV30 = 0 ;
            AV14GXV29 = 0 ;
            AV13GXV28 = 0 ;
            /* Using cursor CARGALECTI3 */
            pr_default.execute(1, new Object[] {A18CargaLectivaId, A4DocenteId});
            while ( (pr_default.getStatus(1) != 101) )
            {
               A28Teoria = CARGALECTI3_A28Teoria[0] ;
               A29Practica = CARGALECTI3_A29Practica[0] ;
               A30Laboratorio = CARGALECTI3_A30Laboratorio[0] ;
               A27Grupo = CARGALECTI3_A27Grupo[0] ;
               A26HorasId = CARGALECTI3_A26HorasId[0] ;
               AV16GXV27 = A27Grupo ;
               AV15GXV30 = A30Laboratorio ;
               AV14GXV29 = A29Practica ;
               AV13GXV28 = A28Teoria ;
               /* Exit For each command. Update data (if necessary), close cursors & exit. */
               if (true) break;
               pr_default.readNext(1);
            }
            pr_default.close(1);
            /*
               INSERT RECORD ON TABLE GXA0012

            */
            AV2CargaLectivaId = A18CargaLectivaId ;
            AV3DocenteId = A4DocenteId ;
            AV4DocenteNombres = A5DocenteNombres ;
            AV5AsignaturaId = A22AsignaturaId ;
            AV6CategoriaId = A7CategoriaId ;
            AV7EscuelaId = A11EscuelaId ;
            AV8Observacion = A25Observacion ;
            AV9Grupo = " " ;
            AV10Laboratorio = 0 ;
            AV11Practica = 0 ;
            AV12Teoria = 0 ;
            /* Using cursor CARGALECTI4 */
            pr_default.execute(2, new Object[] {AV2CargaLectivaId, AV3DocenteId, AV4DocenteNombres, AV5AsignaturaId, AV6CategoriaId, AV7EscuelaId, AV8Observacion, AV9Grupo, AV10Laboratorio, AV11Practica, AV12Teoria});
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
         CARGALECTI2_A25Observacion = new String[] {""} ;
         CARGALECTI2_A11EscuelaId = new short[1] ;
         CARGALECTI2_A7CategoriaId = new short[1] ;
         CARGALECTI2_A22AsignaturaId = new short[1] ;
         CARGALECTI2_A5DocenteNombres = new String[] {""} ;
         CARGALECTI2_A4DocenteId = new short[1] ;
         CARGALECTI2_A18CargaLectivaId = new short[1] ;
         A25Observacion = "" ;
         A5DocenteNombres = "" ;
         AV16GXV27 = "" ;
         CARGALECTI3_A18CargaLectivaId = new short[1] ;
         CARGALECTI3_A4DocenteId = new short[1] ;
         CARGALECTI3_A28Teoria = new short[1] ;
         CARGALECTI3_A29Practica = new short[1] ;
         CARGALECTI3_A30Laboratorio = new short[1] ;
         CARGALECTI3_A27Grupo = new String[] {""} ;
         CARGALECTI3_A26HorasId = new short[1] ;
         A27Grupo = "" ;
         AV4DocenteNombres = "" ;
         AV8Observacion = "" ;
         AV9Grupo = "" ;
         Gx_emsg = "" ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.cargalectivadocenteconversion__default(),
            new Object[][] {
                new Object[] {
               CARGALECTI2_A25Observacion, CARGALECTI2_A11EscuelaId, CARGALECTI2_A7CategoriaId, CARGALECTI2_A22AsignaturaId, CARGALECTI2_A5DocenteNombres, CARGALECTI2_A4DocenteId, CARGALECTI2_A18CargaLectivaId
               }
               , new Object[] {
               CARGALECTI3_A18CargaLectivaId, CARGALECTI3_A4DocenteId, CARGALECTI3_A28Teoria, CARGALECTI3_A29Practica, CARGALECTI3_A30Laboratorio, CARGALECTI3_A27Grupo, CARGALECTI3_A26HorasId
               }
               , new Object[] {
               }
            }
         );
         /* GeneXus formulas. */
         context.Gx_err = 0 ;
      }

      private short A11EscuelaId ;
      private short A7CategoriaId ;
      private short A22AsignaturaId ;
      private short A4DocenteId ;
      private short A18CargaLectivaId ;
      private short AV15GXV30 ;
      private short AV14GXV29 ;
      private short AV13GXV28 ;
      private short A28Teoria ;
      private short A29Practica ;
      private short A30Laboratorio ;
      private short A26HorasId ;
      private short AV2CargaLectivaId ;
      private short AV3DocenteId ;
      private short AV5AsignaturaId ;
      private short AV6CategoriaId ;
      private short AV7EscuelaId ;
      private short AV10Laboratorio ;
      private short AV11Practica ;
      private short AV12Teoria ;
      private int GIGXA0012 ;
      private String scmdbuf ;
      private String Gx_emsg ;
      private String A25Observacion ;
      private String A5DocenteNombres ;
      private String AV16GXV27 ;
      private String A27Grupo ;
      private String AV4DocenteNombres ;
      private String AV8Observacion ;
      private String AV9Grupo ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private String[] CARGALECTI2_A25Observacion ;
      private short[] CARGALECTI2_A11EscuelaId ;
      private short[] CARGALECTI2_A7CategoriaId ;
      private short[] CARGALECTI2_A22AsignaturaId ;
      private String[] CARGALECTI2_A5DocenteNombres ;
      private short[] CARGALECTI2_A4DocenteId ;
      private short[] CARGALECTI2_A18CargaLectivaId ;
      private short[] CARGALECTI3_A18CargaLectivaId ;
      private short[] CARGALECTI3_A4DocenteId ;
      private short[] CARGALECTI3_A28Teoria ;
      private short[] CARGALECTI3_A29Practica ;
      private short[] CARGALECTI3_A30Laboratorio ;
      private String[] CARGALECTI3_A27Grupo ;
      private short[] CARGALECTI3_A26HorasId ;
   }

   public class cargalectivadocenteconversion__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmCARGALECTI2 ;
          prmCARGALECTI2 = new Object[] {
          } ;
          Object[] prmCARGALECTI3 ;
          prmCARGALECTI3 = new Object[] {
          new Object[] {"@CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@DocenteId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmCARGALECTI4 ;
          prmCARGALECTI4 = new Object[] {
          new Object[] {"@AV2CargaLectivaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV3DocenteId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV4DocenteNombres",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV5AsignaturaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV6CategoriaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV7EscuelaId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV8Observacion",SqlDbType.VarChar,100,0} ,
          new Object[] {"@AV9Grupo",SqlDbType.VarChar,2,0} ,
          new Object[] {"@AV10Laboratorio",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV11Practica",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@AV12Teoria",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("CARGALECTI2", "SELECT [Observacion], [EscuelaId], [CategoriaId], [AsignaturaId], [DocenteNombres], [DocenteId], [CargaLectivaId] FROM [CargaLectivaDocente] ORDER BY [CargaLectivaId], [DocenteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCARGALECTI2,100,0,true,false )
             ,new CursorDef("CARGALECTI3", "SELECT TOP 1 [CargaLectivaId], [DocenteId], [Teoria], [Practica], [Laboratorio], [Grupo], [HorasId] FROM [CargaLectivaDocentesHoras] WHERE [CargaLectivaId] = @CargaLectivaId and [DocenteId] = @DocenteId ORDER BY [CargaLectivaId], [DocenteId] ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmCARGALECTI3,1,0,false,true )
             ,new CursorDef("CARGALECTI4", "INSERT INTO [GXA0012] ([CargaLectivaId], [DocenteId], [DocenteNombres], [AsignaturaId], [CategoriaId], [EscuelaId], [Observacion], [Grupo], [Laboratorio], [Practica], [Teoria]) VALUES (@AV2CargaLectivaId, @AV3DocenteId, @AV4DocenteNombres, @AV5AsignaturaId, @AV6CategoriaId, @AV7EscuelaId, @AV8Observacion, @AV9Grupo, @AV10Laboratorio, @AV11Practica, @AV12Teoria)", GxErrorMask.GX_NOMASK,prmCARGALECTI4)
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getVarchar(5) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
                break;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getVarchar(6) ;
                ((short[]) buf[6])[0] = rslt.getShort(7) ;
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
                stmt.SetParameter(2, (short)parms[1]);
                break;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (short)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (String)parms[6]);
                stmt.SetParameter(8, (String)parms[7]);
                stmt.SetParameter(9, (short)parms[8]);
                stmt.SetParameter(10, (short)parms[9]);
                stmt.SetParameter(11, (short)parms[10]);
                break;
       }
    }

 }

}
