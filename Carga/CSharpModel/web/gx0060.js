gx.evt.autoSkip=false;function gx0060(){this.ServerClass="Gx0060";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV9pCargaLectivaId=gx.fn.getIntegerValue("vPCARGALECTIVAID",".")};this.e13082_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e14081_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[2,8,9,12,14,17,19,22,23,27,28,29,32];
this.GXLastCtrlId=32;this.Grid1Container=new gx.grid.grid(this,2,"WbpLvl2",26,"Grid1","Grid1","Grid1Container",this.CmpContext,this.IsMasterPage,"gx0060",[],false,1,false,true,10,true,false,false,"",0,"px","Nueva fila",true,false,false,null,null,false,"");this.Grid1Container.addBitmap("&Linkselection","vLINKSELECTION",27,0,"px",17,"px",null,"","");this.Grid1Container.addSingleLineEdit(18,28,"CARGALECTIVAID","Id","","CargaLectivaId","int",0,"px",4,4,"right",null,[],18,"CargaLectivaId",true,0,false,false);
this.Grid1Container.addSingleLineEdit(19,29,"CARGALECTIVAFECHA","Fecha","Seleccionar","CargaLectivaFecha","date",0,"px",8,8,"right",null,[],19,"CargaLectivaFecha",true,0,false,false);this.setGrid(this.Grid1Container);this.GXValidFnc[2]={fld:"TABLE1",grid:0};this.GXValidFnc[8]={fld:"GROUP1",grid:0};this.GXValidFnc[9]={fld:"TABLE2",grid:0};this.GXValidFnc[12]={fld:"TEXTBLOCKCARGALECTIVAID",format:0,grid:0};this.GXValidFnc[14]={lvl:0,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,rgrid:[this.Grid1Container],fld:"vCCARGALECTIVAID",gxz:"ZV6cCargaLectivaId",gxold:"OV6cCargaLectivaId",gxvar:"AV6cCargaLectivaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV6cCargaLectivaId=gx.num.intval(a)
},v2z:function(a){gx.O.ZV6cCargaLectivaId=gx.num.intval(a)},v2c:function(){gx.fn.setControlValue("vCCARGALECTIVAID",gx.O.AV6cCargaLectivaId,0)},c2v:function(){gx.O.AV6cCargaLectivaId=this.val()},val:function(){return gx.fn.getIntegerValue("vCCARGALECTIVAID",".")},nac:function(){return false}};this.GXValidFnc[17]={fld:"TEXTBLOCKCARGALECTIVAFECHA",format:0,grid:0};this.GXValidFnc[19]={lvl:0,type:"date",len:8,dec:0,sign:false,ro:0,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"vCCARGALECTIVAFECHA",gxz:"ZV7cCargaLectivaFecha",gxold:"OV7cCargaLectivaFecha",gxvar:"AV7cCargaLectivaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV7cCargaLectivaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.ZV7cCargaLectivaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setControlValue("vCCARGALECTIVAFECHA",gx.O.AV7cCargaLectivaFecha,0)},c2v:function(){gx.O.AV7cCargaLectivaFecha=this.val()},val:function(){return gx.fn.getControlValue("vCCARGALECTIVAFECHA")},nac:function(){return false}};this.GXValidFnc[22]={fld:"GROUP2",grid:0};this.GXValidFnc[23]={fld:"TABLE3",grid:0};this.GXValidFnc[27]={lvl:2,type:"bits",len:4,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"vLINKSELECTION",gxz:"ZV5LinkSelection",gxold:"OV5LinkSelection",gxvar:"AV5LinkSelection",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.AV5LinkSelection=a
},v2z:function(a){gx.O.ZV5LinkSelection=a},v2c:function(){},c2v:function(){gx.O.AV5LinkSelection=this.val()},val:function(){return gx.fn.getGridControlValue("vLINKSELECTION",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[28]={lvl:2,type:"int",len:4,dec:0,sign:false,pic:"ZZZ9",ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,rgrid:[],fld:"CARGALECTIVAID",gxz:"Z18CargaLectivaId",gxold:"O18CargaLectivaId",gxvar:"A18CargaLectivaId",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A18CargaLectivaId=gx.num.intval(a)
},v2z:function(a){gx.O.Z18CargaLectivaId=gx.num.intval(a)},v2c:function(){gx.fn.setGridControlValue("CARGALECTIVAID",gx.fn.currentGridRowImpl(26),gx.O.A18CargaLectivaId,0)},c2v:function(){gx.O.A18CargaLectivaId=this.val()},val:function(){return gx.fn.getGridIntegerValue("CARGALECTIVAID",gx.fn.currentGridRowImpl(26),".")},nac:function(){return false}};this.GXValidFnc[29]={lvl:2,type:"date",len:8,dec:0,sign:false,ro:1,grid:26,gxgrid:this.Grid1Container,fnc:null,isvalid:null,fld:"CARGALECTIVAFECHA",gxz:"Z19CargaLectivaFecha",gxold:"O19CargaLectivaFecha",gxvar:"A19CargaLectivaFecha",dp:{f:0,st:false,wn:false,mf:false,pic:"99/99/99",dec:0},ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A19CargaLectivaFecha=gx.fn.toDatetimeValue(a)
},v2z:function(a){gx.O.Z19CargaLectivaFecha=gx.fn.toDatetimeValue(a)},v2c:function(){gx.fn.setGridControlValue("CARGALECTIVAFECHA",gx.fn.currentGridRowImpl(26),gx.O.A19CargaLectivaFecha,0)},c2v:function(){gx.O.A19CargaLectivaFecha=this.val()},val:function(){return gx.fn.getGridControlValue("CARGALECTIVAFECHA",gx.fn.currentGridRowImpl(26))},nac:function(){return false}};this.GXValidFnc[32]={fld:"TABLE4",grid:0};this.AV6cCargaLectivaId=0;this.ZV6cCargaLectivaId=0;this.OV6cCargaLectivaId=0;this.AV7cCargaLectivaFecha=gx.date.nullDate();
this.ZV7cCargaLectivaFecha=gx.date.nullDate();this.OV7cCargaLectivaFecha=gx.date.nullDate();this.ZV5LinkSelection="";this.OV5LinkSelection="";this.Z18CargaLectivaId=0;this.O18CargaLectivaId=0;this.Z19CargaLectivaFecha=gx.date.nullDate();this.O19CargaLectivaFecha=gx.date.nullDate();this.AV9pCargaLectivaId=0;this.AV5LinkSelection="";this.A18CargaLectivaId=0;this.A19CargaLectivaFecha=gx.date.nullDate();this.ServerEvents=["e13082_client","e14081_client"];this.VarControlMap.AV9pCargaLectivaId={id:"vPCARGALECTIVAID",grid:0,type:"int"};
this.Grid1Container.addRefreshingVar(this.GXValidFnc[14]);this.Grid1Container.addRefreshingVar(this.GXValidFnc[19]);this.SetStandaloneVars()}gx0060.prototype=new gx.GxObject;gx.setParentObj(new gx0060());