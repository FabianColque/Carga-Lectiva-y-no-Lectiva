gx.evt.autoSkip=false;function cargalectiva(){this.ServerClass="CargaLectiva";this.PackageName="GeneXus.Programs";this.setObjectType("trn");this.hasEnterEvent=true;this.SetStandaloneVars=function(){this.Gx_mode=gx.fn.getControlValue("vMODE")};this.Valid_Cargalectivaid=function(){gx.ajax.validSrvEvt("dyncall","Valid_Cargalectivaid",["gx.O.A18CargaLectivaId",'gx.date.urlDate(gx.O.A19CargaLectivaFecha,"DMY")'],["A19CargaLectivaFecha","Gx_mode","Z18CargaLectivaId","Z19CargaLectivaFecha","Gridcargalectiva_detalle",["BTN_ENTER2","Enabled"]]);
return true};this.Valid_Cargalectivafecha=function(){try{var a=gx.util.balloon.getNew("CARGALECTIVAFECHA");this.AnyError=0;if(!((new gx.date.gxdate("").compare(this.A19CargaLectivaFecha)==0)||new gx.date.gxdate(this.A19CargaLectivaFecha).compare(gx.date.ymdtod(1753,1,1))>=0)){try{a.setError("Campo Fecha fuera de rango");this.AnyError=1}catch(b){}}}catch(b){}try{if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Cargadetalleid=function(){try{if(gx.fn.currentGridRowImpl(50)===0){return true
}var a=gx.util.balloon.getNew("CARGADETALLEID",gx.fn.currentGridRowImpl(50));this.AnyError=0;this.sMode15=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(15,50);this.standaloneModal0115();this.standaloneNotModal0115();if(gx.fn.gridDuplicateKey(51)){a.setError(gx.text.format(gx.getMessage("GXM_1004"),"Detalle","","","","","","","",""));this.AnyError=1}}catch(b){}try{this.Gx_mode=this.sMode15;if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Docenteid=function(){this.sMode15=this.Gx_mode;
this.Gx_mode=gx.fn.getGridRowMode(15,50);gx.ajax.validSrvEvt("dyncall","Valid_Docenteid",["gx.O.A4DocenteId","gx.O.A5DocenteNombres"],["A5DocenteNombres"]);this.Gx_mode=this.sMode15;return true};this.Valid_Asignaturaid=function(){this.sMode15=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(15,50);gx.ajax.validSrvEvt("dyncall","Valid_Asignaturaid",["gx.O.A22AsignaturaId","gx.O.A23AsignaturaNombre"],["A23AsignaturaNombre"]);this.Gx_mode=this.sMode15;return true};this.Valid_Escuelaid=function(){this.sMode15=this.Gx_mode;
this.Gx_mode=gx.fn.getGridRowMode(15,50);gx.ajax.validSrvEvt("dyncall","Valid_Escuelaid",["gx.O.A11EscuelaId","gx.O.A12EscuelaNombre"],["A12EscuelaNombre"]);this.Gx_mode=this.sMode15;return true};this.Valid_Teoria=function(){try{if(gx.fn.currentGridRowImpl(50)===0){return true}var a=gx.util.balloon.getNew("TEORIA",gx.fn.currentGridRowImpl(50));this.AnyError=0;this.sMode15=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(15,50)}catch(b){}try{this.Gx_mode=this.sMode15;if(a==null){return true}return a.show()
}catch(b){}return true};this.Valid_Practica=function(){try{if(gx.fn.currentGridRowImpl(50)===0){return true}var a=gx.util.balloon.getNew("PRACTICA",gx.fn.currentGridRowImpl(50));this.AnyError=0;this.sMode15=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(15,50)}catch(b){}try{this.Gx_mode=this.sMode15;if(a==null){return true}return a.show()}catch(b){}return true};this.Valid_Laboratorio=function(){try{if(gx.fn.currentGridRowImpl(50)===0){return true}var a=gx.util.balloon.getNew("LABORATORIO",gx.fn.currentGridRowImpl(50));
this.AnyError=0;this.sMode15=this.Gx_mode;this.Gx_mode=gx.fn.getGridRowMode(15,50);try{this.A31Total=this.A28Teoria+this.A29Practica+this.A30Laboratorio}catch(b){}}catch(b){}try{this.Gx_mode=this.sMode15;if(a==null){return true}return a.show()}catch(b){}return true};this.standaloneModal0115=function(){try{if(this.Gx_mode!="INS"){gx.fn.setCtrlProperty("CARGADETALLEID","Enabled",0)}else{gx.fn.setCtrlProperty("CARGADETALLEID","Enabled",1)}}catch(a){}return true};this.standaloneNotModal0115=function(){return true
};this.e11016_client=function(){this.executeServerEvent("ENTER",true)};this.e12016_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,5,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,26,27,33,36,38,41,43,46,49,51,52,53,54,55,56,57,58,59,60,61,62,63];this.GXLastCtrlId=63;this.Gridcargalectiva_detalleContainer=new gx.grid.grid(this,15,"Detalle",50,"Gridcargalectiva_detalle","Gridcargalectiva_detalle","Gridcargalectiva_detalleContainer",this.CmpContext,this.IsMasterPage,"cargalectiva",[42],false,1,false,true,5,false,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");
this.Gridcargalectiva_detalleContainer.addSingleLineEdit(42,51,"CARGADETALLEID","Detalle Id","","CargaDetalleId","int",0,"px",4,4,"right",null,[],42,"CargaDetalleId",true,0,false,false);this.Gridcargalectiva_detalleContainer.addSingleLineEdit(4,52,"DOCENTEID","Docente Id","","DocenteId","int",0,"px",4,4,"right",null,[],4,"DocenteId",true,0,false,false);this.Gridcargalectiva_detalleContainer.addBitmap("prompt_4","PROMPT_4",69,0,"",0,"",null,"","");this.Gridcargalectiva_detalleContainer.addSingleLineEdit(5,53,"DOCENTENOMBRES","Docente","","DocenteNombres","svchar",0,"px",100,100,"left",null,[],5,"DocenteNombres",true,0,false,false);
this.Gridcargalectiva_detalleContainer.addSingleLineEdit(22,54,"ASIGNATURAID","A","","AsignaturaId","int",0,"px",4,4,"right",null,[],22,"AsignaturaId",true,0,false,false);this.Gridcargalectiva_detalleContainer.addBitmap("prompt_22","PROMPT_22",70,0,"",0,"",null,"","");this.Gridcargalectiva_detalleContainer.addSingleLineEdit(23,55,"ASIGNATURANOMBRE","Asignatura ","","AsignaturaNombre","svchar",0,"px",60,60,"left",null,[],23,"AsignaturaNombre",true,0,false,false);this.Gridcargalectiva_detalleContainer.addSingleLineEdit(11,56,"ESCUELAID","E","","EscuelaId","int",0,"px",4,4,"right",null,[],11,"EscuelaId",true,0,false,false);
this.Gridcargalectiva_detalleContainer.addBitmap("prompt_11","PROMPT_11",71,0,"",0,"",null,"","");this.Gridcargalectiva_detalleContainer.addSingleLineEdit(12,57,"ESCUELANOMBRE","Escuela ","","EscuelaNombre","svchar",0,"px",60,60,"left",null,[],12,"EscuelaNombre",true,0,false,false);this.Gridcargalectiva_detalleContainer.addSingleLineEdit(27,58,"GRUPO","Grupo","","Grupo","svchar",0,"px",2,2,"left",null,[],27,"Grupo",true,0,false,false);this.Gridcargalectiva_detalleContainer.addSingleLineEdit(28,59,"TEORIA","Teoria","","Teoria","int",0,"px",4,4,"right",null,[],28,"Teoria",true,0,false,false);
this.Gridcargalectiva_detalleContainer.addSingleLineEdit(29,60,"PRACTICA","Practica","","Practica","int",0,"px",4,4,"right",null,[],29,"Practica",true,0,false,false);this.Gridcargalectiva_detalleContainer.addSingleLineEdit(30,61,"LABORATORIO","Laboratorio","","Laboratorio","int",0,"px",4,4,"right",null,[],30,"Laboratorio",true,0,false,false);this.Gridcargalectiva_detalleContainer.addSingleLineEdit(31,62,"TOTAL","Total","","Total","int",0,"px",4,4,"right",null,[],31,"Total",true,0,false,false);this.Gridcargalectiva_detalleContainer.addSingleLineEdit(25,63,"OBSERVACION","Observacion","","Observacion","svchar",0,"px",100,100,"left",null,[],25,"Observacion",true,0,false,false);
this.setGrid(this.Gridcargalectiva_detalleContainer);this.GXValidFnc[2]={fld:"TABLEMAIN",grid:0};this.GXValidFnc[5]={fld:"TABLETOOLBAR",grid:0};this.GXValidFnc[8]={fld:"BTN_FIRST",grid:0};this.GXValidFnc[9]={fld:"BTN_FIRST_SEPARATOR",grid:0};this.GXValidFnc[10]={fld:"BTN_PREVIOUS",grid:0};this.GXValidFnc[11]={fld:"BTN_PREVIOUS_SEPARATOR",grid:0};this.GXValidFnc[12]={fld:"BTN_NEXT",grid:0};this.GXValidFnc[13]={fld:"BTN_NEXT_SEPARATOR",grid:0};this.GXValidFnc[14]={fld:"BTN_LAST",grid:0};this.GXValidFnc[15]={fld:"BTN_LAST_SEPARATOR",grid:0};
this.GXValidFnc[16]={fld:"BTN_SELECT",grid:0};this.GXValidFnc[17]={fld:"BTN_SELECT_SEPARATOR",grid:0};this.GXValidFnc[18]={fld:"BTN_ENTER2",grid:0};this.GXValidFnc[19]={fld:"BTN_ENTER2_SEPARATOR",grid:0};this.GXValidFnc[20]={fld:"BTN_CANCEL2",grid:0};this.GXValidFnc[21]={fld:"BTN_CANCEL2_SEPARATOR",grid:0};this.GXValidFnc[22]={fld:"BTN_DELETE2",grid:0};this.GXValidFnc[23]={fld:"BTN_DELETE2_SEPARATOR",grid:0};this.GXValidFnc[26]={fld:"GROUPDATA",grid:0};this.GXValidFnc[27]={fld:"TABLE1",grid:0};this.GXValidFnc[33]={fld:"TABLE2",grid:0};
this.GXValidFnc[36]={fld:"TEXTBLOCKCARGALECTIVAID",format:0,grid:0};this.GXValidFnc[38]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:this.Valid_Cargalectivaid,isvalid:null,rgrid:[this.Gridcargalectiva_detalleContainer],fld:"CARGALECTIVAID",gxz:"Z18CargaLectivaId",gxold:"O18CargaLectivaId",gxvar:"A18CargaLectivaId",ucs:[],op:[43],ip:[43,38],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A18CargaLectivaId=gx.num.intval(a)},v2z:function(a){gx.O.Z18CargaLectivaId=gx.num.intval(a)
},v2c:function(){gx.fn.setControlValue("CARGALECTIVAID",gx.O.A18CargaLectivaId,0)},c2v:function(){gx.O.A18CargaLectivaId=this.val()},val:function(){return gx.fn.getIntegerValue("CARGALECTIVAID",".")},nac:function(){return false}};this.GXValidFnc[41]={fld:"TEXTBLOCKCARGALECTIVAFECHA",format:0,grid:0};this.GXValidFnc[43]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:this.Valid_Cargalectivafecha,isvalid:null,fld:"CARGALECTIVAFECHA",gxz:"Z19CargaLectivaFecha",gxold:"O19CargaLectivaFecha",gxvar:"A19CargaLectivaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[43],ip:[43],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A19CargaLectivaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z19CargaLectivaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("CARGALECTIVAFECHA",gx.O.A19CargaLectivaFecha,0)},c2v:function(){gx.O.A19CargaLectivaFecha=this.val()},val:function(){return gx.fn.getControlValue("CARGALECTIVAFECHA")},nac:function(){return false}};this.GXValidFnc[46]={fld:"TABLE3",grid:0};this.GXValidFnc[49]={fld:"TITLEDETALLE",format:0,grid:0};this.GXValidFnc[51]={lvl:15,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:this.Valid_Cargadetalleid,isvalid:null,rgrid:[],fld:"CARGADETALLEID",gxz:"Z42CargaDetalleId",gxold:"O42CargaDetalleId",gxvar:"A42CargaDetalleId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A42CargaDetalleId=gx.num.intval(a)
},v2z:function(a){gx.O.Z42CargaDetalleId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("CARGADETALLEID",gx.fn.currentGridRowImpl(50),gx.O.A42CargaDetalleId,0)},c2v:function(){gx.O.A42CargaDetalleId=this.val()},val:function(){return gx.fn.getGridIntegerValue("CARGADETALLEID",gx.fn.currentGridRowImpl(50),".")},nac:function(){return false}};this.GXValidFnc[52]={lvl:15,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:this.Valid_Docenteid,isvalid:null,rgrid:[],fld:"DOCENTEID",gxz:"Z4DocenteId",gxold:"O4DocenteId",gxvar:"A4DocenteId",ucs:[],op:[53],ip:[53,52],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A4DocenteId=gx.num.intval(a)
},v2z:function(a){gx.O.Z4DocenteId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("DOCENTEID",gx.fn.currentGridRowImpl(50),gx.O.A4DocenteId,0)},c2v:function(){gx.O.A4DocenteId=this.val()},val:function(){return gx.fn.getGridIntegerValue("DOCENTEID",gx.fn.currentGridRowImpl(50),".")},nac:function(){return false}};this.GXValidFnc[53]={lvl:15,type:"svchar",len:100,dec:0,sign:false,ro:1,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:null,isvalid:null,fld:"DOCENTENOMBRES",gxz:"Z5DocenteNombres",gxold:"O5DocenteNombres",gxvar:"A5DocenteNombres",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A5DocenteNombres=a
},v2z:function(a){gx.O.Z5DocenteNombres=a},v2c:function(){gx.fn.setGridControlValue("DOCENTENOMBRES",gx.fn.currentGridRowImpl(50),gx.O.A5DocenteNombres,0)},c2v:function(){gx.O.A5DocenteNombres=this.val()},val:function(){return gx.fn.getGridControlValue("DOCENTENOMBRES",gx.fn.currentGridRowImpl(50))},nac:function(){return false}};this.GXValidFnc[54]={lvl:15,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:this.Valid_Asignaturaid,isvalid:null,rgrid:[],fld:"ASIGNATURAID",gxz:"Z22AsignaturaId",gxold:"O22AsignaturaId",gxvar:"A22AsignaturaId",ucs:[],op:[55],ip:[55,54],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A22AsignaturaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z22AsignaturaId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("ASIGNATURAID",gx.fn.currentGridRowImpl(50),gx.O.A22AsignaturaId,0)},c2v:function(){gx.O.A22AsignaturaId=this.val()},val:function(){return gx.fn.getGridIntegerValue("ASIGNATURAID",gx.fn.currentGridRowImpl(50),".")},nac:function(){return false}};this.GXValidFnc[55]={lvl:15,type:"svchar",len:60,dec:0,sign:false,ro:1,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:null,isvalid:null,fld:"ASIGNATURANOMBRE",gxz:"Z23AsignaturaNombre",gxold:"O23AsignaturaNombre",gxvar:"A23AsignaturaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A23AsignaturaNombre=a
},v2z:function(a){gx.O.Z23AsignaturaNombre=a},v2c:function(){gx.fn.setGridControlValue("ASIGNATURANOMBRE",gx.fn.currentGridRowImpl(50),gx.O.A23AsignaturaNombre,0)},c2v:function(){gx.O.A23AsignaturaNombre=this.val()},val:function(){return gx.fn.getGridControlValue("ASIGNATURANOMBRE",gx.fn.currentGridRowImpl(50))},nac:function(){return false}};this.GXValidFnc[56]={lvl:15,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:this.Valid_Escuelaid,isvalid:null,rgrid:[],fld:"ESCUELAID",gxz:"Z11EscuelaId",gxold:"O11EscuelaId",gxvar:"A11EscuelaId",ucs:[],op:[57],ip:[57,56],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A11EscuelaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z11EscuelaId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("ESCUELAID",gx.fn.currentGridRowImpl(50),gx.O.A11EscuelaId,0)},c2v:function(){gx.O.A11EscuelaId=this.val()},val:function(){return gx.fn.getGridIntegerValue("ESCUELAID",gx.fn.currentGridRowImpl(50),".")},nac:function(){return false}};this.GXValidFnc[57]={lvl:15,type:"svchar",len:60,dec:0,sign:false,ro:1,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:null,isvalid:null,fld:"ESCUELANOMBRE",gxz:"Z12EscuelaNombre",gxold:"O12EscuelaNombre",gxvar:"A12EscuelaNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A12EscuelaNombre=a
},v2z:function(a){gx.O.Z12EscuelaNombre=a},v2c:function(){gx.fn.setGridControlValue("ESCUELANOMBRE",gx.fn.currentGridRowImpl(50),gx.O.A12EscuelaNombre,0)},c2v:function(){gx.O.A12EscuelaNombre=this.val()},val:function(){return gx.fn.getGridControlValue("ESCUELANOMBRE",gx.fn.currentGridRowImpl(50))},nac:function(){return false}};this.GXValidFnc[58]={lvl:15,type:"svchar",len:2,dec:0,sign:false,ro:0,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:null,isvalid:null,fld:"GRUPO",gxz:"Z27Grupo",gxold:"O27Grupo",gxvar:"A27Grupo",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A27Grupo=a
},v2z:function(a){gx.O.Z27Grupo=a},v2c:function(){gx.fn.setGridControlValue("GRUPO",gx.fn.currentGridRowImpl(50),gx.O.A27Grupo,0)},c2v:function(){gx.O.A27Grupo=this.val()},val:function(){return gx.fn.getGridControlValue("GRUPO",gx.fn.currentGridRowImpl(50))},nac:function(){return false}};this.GXValidFnc[59]={lvl:15,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:this.Valid_Teoria,isvalid:null,rgrid:[],fld:"TEORIA",gxz:"Z28Teoria",gxold:"O28Teoria",gxvar:"A28Teoria",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A28Teoria=gx.num.intval(a)
},v2z:function(a){gx.O.Z28Teoria=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("TEORIA",gx.fn.currentGridRowImpl(50),gx.O.A28Teoria,0)},c2v:function(){gx.O.A28Teoria=this.val()},val:function(){return gx.fn.getGridIntegerValue("TEORIA",gx.fn.currentGridRowImpl(50),".")},nac:function(){return false}};this.GXValidFnc[60]={lvl:15,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:this.Valid_Practica,isvalid:null,rgrid:[],fld:"PRACTICA",gxz:"Z29Practica",gxold:"O29Practica",gxvar:"A29Practica",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A29Practica=gx.num.intval(a)
},v2z:function(a){gx.O.Z29Practica=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("PRACTICA",gx.fn.currentGridRowImpl(50),gx.O.A29Practica,0)},c2v:function(){gx.O.A29Practica=this.val()},val:function(){return gx.fn.getGridIntegerValue("PRACTICA",gx.fn.currentGridRowImpl(50),".")},nac:function(){return false}};this.GXValidFnc[61]={lvl:15,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:this.Valid_Laboratorio,isvalid:null,rgrid:[],fld:"LABORATORIO",gxz:"Z30Laboratorio",gxold:"O30Laboratorio",gxvar:"A30Laboratorio",ucs:[],op:[62],ip:[62,61,60,59],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A30Laboratorio=gx.num.intval(a)
},v2z:function(a){gx.O.Z30Laboratorio=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("LABORATORIO",gx.fn.currentGridRowImpl(50),gx.O.A30Laboratorio,0)},c2v:function(){gx.O.A30Laboratorio=this.val()},val:function(){return gx.fn.getGridIntegerValue("LABORATORIO",gx.fn.currentGridRowImpl(50),".")},nac:function(){return false}};this.GXValidFnc[62]={lvl:15,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:null,isvalid:null,rgrid:[],fld:"TOTAL",gxz:"Z31Total",gxold:"O31Total",gxvar:"A31Total",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A31Total=gx.num.intval(a)
},v2z:function(a){gx.O.Z31Total=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("TOTAL",gx.fn.currentGridRowImpl(50),gx.O.A31Total,0)},c2v:function(){gx.O.A31Total=this.val()},val:function(){return gx.fn.getGridIntegerValue("TOTAL",gx.fn.currentGridRowImpl(50),".")},nac:function(){return false}};this.GXValidFnc[63]={lvl:15,type:"svchar",len:100,dec:0,sign:false,ro:0,grid:50,gxgrid:this.Gridcargalectiva_detalleContainer,fnc:null,isvalid:null,fld:"OBSERVACION",gxz:"Z25Observacion",gxold:"O25Observacion",gxvar:"A25Observacion",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A25Observacion=a
},v2z:function(a){gx.O.Z25Observacion=a},v2c:function(){gx.fn.setGridControlValue("OBSERVACION",gx.fn.currentGridRowImpl(50),gx.O.A25Observacion,0)},c2v:function(){gx.O.A25Observacion=this.val()},val:function(){return gx.fn.getGridControlValue("OBSERVACION",gx.fn.currentGridRowImpl(50))},nac:function(){return false}};this.A18CargaLectivaId=0;this.Z18CargaLectivaId=0;this.O18CargaLectivaId=0;this.A19CargaLectivaFecha=gx.date.nullDate();this.Z19CargaLectivaFecha=gx.date.nullDate();this.O19CargaLectivaFecha=gx.date.nullDate();
this.Z42CargaDetalleId=0;this.O42CargaDetalleId=0;this.Z4DocenteId=0;this.O4DocenteId=0;this.Z5DocenteNombres="";this.O5DocenteNombres="";this.Z22AsignaturaId=0;this.O22AsignaturaId=0;this.Z23AsignaturaNombre="";this.O23AsignaturaNombre="";this.Z11EscuelaId=0;this.O11EscuelaId=0;this.Z12EscuelaNombre="";this.O12EscuelaNombre="";this.Z27Grupo="";this.O27Grupo="";this.Z28Teoria=0;this.O28Teoria=0;this.Z29Practica=0;this.O29Practica=0;this.Z30Laboratorio=0;this.O30Laboratorio=0;this.Z31Total=0;this.O31Total=0;
this.Z25Observacion="";this.O25Observacion="";this.A42CargaDetalleId=0;this.A31Total=0;this.A4DocenteId=0;this.A5DocenteNombres="";this.A22AsignaturaId=0;this.A23AsignaturaNombre="";this.A11EscuelaId=0;this.A12EscuelaNombre="";this.A27Grupo="";this.A28Teoria=0;this.A29Practica=0;this.A30Laboratorio=0;this.A25Observacion="";this.ServerEvents=["e11016_client","e12016_client"];this.setPrompt("PROMPT_4",[52]);this.setPrompt("PROMPT_22",[54]);this.setPrompt("PROMPT_11",[56]);this.EnterCtrl=["BTN_ENTER2","BTN_ENTER2_SEPARATOR","BTN_ENTER"];
this.VarControlMap.Gx_mode={id:"vMODE",grid:0,type:"char"};this.SetStandaloneVars()}cargalectiva.prototype=new gx.GxObject;gx.setParentObj(new cargalectiva());