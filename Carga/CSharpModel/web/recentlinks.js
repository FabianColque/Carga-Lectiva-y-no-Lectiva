gx.evt.autoSkip=false;function recentlinks(a){this.ServerClass="RecentLinks";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.setCmpContext(a);this.ReadonlyForm=true;this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){};this.e12022_client=function(){this.executeServerEvent("ENTER",true,arguments[0])};this.e13022_client=function(){this.executeServerEvent("CANCEL",true,arguments[0])};this.GXValidFnc=[];this.GXCtrlIds=[2,5,10,13];this.GXLastCtrlId=13;this.LinksContainer=new gx.grid.grid(this,2,"WbpLvl2",7,"Links","Links","LinksContainer",this.CmpContext,this.IsMasterPage,"recentlinks",[],true,0,true,true,0,false,false,false,"",0,"px","Nueva fila",false,false,false,null,null,false,"");
this.LinksContainer.startRow("","","","","","");this.LinksContainer.startCell("","","","","","","","","","");this.LinksContainer.addTextBlock("PLACE",null);this.LinksContainer.endCell();this.LinksContainer.startCell("","","","","","","","","","td100");this.LinksContainer.endCell();this.LinksContainer.endRow();this.setGrid(this.LinksContainer);this.GXValidFnc[2]={fld:"TABLE",grid:0};this.GXValidFnc[5]={fld:"RECENTTEXT",format:0,grid:0};this.GXValidFnc[10]={fld:"PLACE",format:0,grid:7};this.GXValidFnc[13]={fld:"BOTTOMLINE",grid:0};
this.AV6FormCaption="";this.AV7FormPgmName="";this.ServerEvents=["e12022_client","e13022_client"];this.VarControlMap.AV6FormCaption={id:"vFORMCAPTION",grid:0,type:"char"};this.LinksContainer.addRefreshingVar({rfrVar:"AV6FormCaption"});this.SetStandaloneVars()};