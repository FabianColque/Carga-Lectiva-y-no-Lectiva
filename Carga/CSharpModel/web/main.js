gx.evt.autoSkip=false;function main(){this.ServerClass="Main";this.PackageName="GeneXus.Programs";this.setObjectType("web");this.hasEnterEvent=false;this.autoRefresh=true;this.SetStandaloneVars=function(){this.AV6MenuDataItem=gx.fn.getControlValue("vMENUDATAITEM")};this.e130k1_client=function(){this.clearMessages();this.addMessage("Selected item Title : "+this.AV6MenuDataItem.MenuTitle);this.refreshOutputs([])};this.e140k2_client=function(){this.executeServerEvent("ENTER",true)};this.e150k2_client=function(){this.executeServerEvent("CANCEL",true)
};this.GXValidFnc=[];this.GXCtrlIds=[2,5,9,11,12,19,22,26,29,32,35,38,39,42];this.GXLastCtrlId=42;this.DOLPHINSTYLEMENU2Container=gx.uc.getNew(this,15,0,"DolphinStyleMenu","DOLPHINSTYLEMENU2Container","Dolphinstylemenu2");this.DOLPHINSTYLEMENU2Container.setProperty("Width","Width","169","str");this.DOLPHINSTYLEMENU2Container.setProperty("Height","Height","60","str");this.DOLPHINSTYLEMENU2Container.addV2CFunction(function(a){a.ParentObject.AV5MenuData=gx.fn.getControlValue("vMENUDATA");a.SetMenuData(a.ParentObject.AV5MenuData)
});this.DOLPHINSTYLEMENU2Container.addC2VFunction(function(a){a.ParentObject.AV5MenuData=a.GetMenuData();gx.fn.setControlValue("vMENUDATA",a.ParentObject.AV5MenuData)});this.DOLPHINSTYLEMENU2Container.addV2CFunction(function(a){a.ParentObject.AV6MenuDataItem=gx.fn.getControlValue("vMENUDATAITEM");a.SetSelectedItem(a.ParentObject.AV6MenuDataItem)});this.DOLPHINSTYLEMENU2Container.addC2VFunction(function(a){a.ParentObject.AV6MenuDataItem=a.GetSelectedItem();gx.fn.setControlValue("vMENUDATAITEM",a.ParentObject.AV6MenuDataItem)
});this.DOLPHINSTYLEMENU2Container.setProperty("Visible","Visible",true,"bool");this.DOLPHINSTYLEMENU2Container.setC2ShowFunction(function(a){a.show()});this.DOLPHINSTYLEMENU2Container.addEventHandler("DolphinItemClicked",this.e130k1_client);this.setUserControl(this.DOLPHINSTYLEMENU2Container);this.GXValidFnc[2]={fld:"TABLE4",grid:0};this.GXValidFnc[5]={fld:"TABLE1",grid:0};this.GXValidFnc[9]={fld:"TEXTBLOCKHEADER1",format:0,grid:0};this.GXValidFnc[11]={fld:"IMAGE1",grid:0};this.GXValidFnc[12]={fld:"TABLE2",grid:0};
this.GXValidFnc[19]={fld:"TABLE5",grid:0};this.GXValidFnc[22]={fld:"IMAGE2",grid:0};this.GXValidFnc[26]={fld:"TABLE6",grid:0};this.GXValidFnc[29]={fld:"TABLE7",grid:0};this.GXValidFnc[32]={fld:"TABLE8",grid:0};this.GXValidFnc[35]={fld:"TABLE3",grid:0};this.GXValidFnc[38]={fld:"TEXTBLOCK1",format:0,grid:0};this.GXValidFnc[39]={fld:"TABLE9",grid:0};this.GXValidFnc[42]={fld:"TABLE10",grid:0};this.AV5MenuData=[];this.AV6MenuDataItem={};this.ServerEvents=["e140k2_client","e150k2_client"];this.VarControlMap.AV6MenuDataItem={id:"vMENUDATAITEM",grid:0,type:"MenuData.MenuDataItem"};
this.SetStandaloneVars()}main.prototype=new gx.GxObject;gx.setParentObj(new main());