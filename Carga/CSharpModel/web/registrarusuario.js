gx.evt.autoSkip=false;function registrarusuario(){this.ServerClass="RegistrarUsuario";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=true;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e110i2_client=function(){this.executeServerEvent("ENTER",true)};this.e130i2_client=function(){this.executeServerEvent("CANCEL",true)};this.GXValidFnc=[];this.GXCtrlIds=[3,6,8,11,13];this.GXLastCtrlId=13;this.GXValidFnc[3]={fld:"TABLE1",grid:0};this.GXValidFnc[6]={fld:"TEXTBLOCK1",format:0,grid:0};
this.GXValidFnc[8]={lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USUARIOSNOMBRE",gxz:"Z43UsuariosNombre",gxold:"O43UsuariosNombre",gxvar:"A43UsuariosNombre",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A43UsuariosNombre=a},v2z:function(a){gx.O.Z43UsuariosNombre=a},v2c:function(){gx.fn.setControlValue("USUARIOSNOMBRE",gx.O.A43UsuariosNombre,0)},c2v:function(){gx.O.A43UsuariosNombre=this.val()},val:function(){return gx.fn.getControlValue("USUARIOSNOMBRE")
},nac:function(){return false}};this.GXValidFnc[11]={fld:"TEXTBLOCK2",format:0,grid:0};this.GXValidFnc[13]={lvl:0,type:"svchar",len:40,dec:0,sign:false,ro:1,grid:0,gxgrid:null,fnc:null,isvalid:null,fld:"USUARIOSPASSWORD",gxz:"Z44UsuariosPassword",gxold:"O44UsuariosPassword",gxvar:"A44UsuariosPassword",ucs:[],op:[],ip:[],nacdep:[],ctrltype:"edit",v2v:function(a){gx.O.A44UsuariosPassword=a},v2z:function(a){gx.O.Z44UsuariosPassword=a},v2c:function(){gx.fn.setControlValue("USUARIOSPASSWORD",gx.O.A44UsuariosPassword,0)
},c2v:function(){gx.O.A44UsuariosPassword=this.val()},val:function(){return gx.fn.getControlValue("USUARIOSPASSWORD")},nac:function(){return false}};this.A43UsuariosNombre="";this.Z43UsuariosNombre="";this.O43UsuariosNombre="";this.A44UsuariosPassword="";this.Z44UsuariosPassword="";this.O44UsuariosPassword="";this.ServerEvents=["e110i2_client","e130i2_client"];this.EnterCtrl=["BUTTON1"];this.SetStandaloneVars()}registrarusuario.prototype=new gx.GxObject;gx.setParentObj(new registrarusuario());