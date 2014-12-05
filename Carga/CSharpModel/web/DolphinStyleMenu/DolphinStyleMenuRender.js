function DolphinStyleMenu()
{
	this.MenuData;
	this.SelectedItem;
	this.Width;
	this.Height;

	// Databinding for property MenuData
	this.SetMenuData = function(data)
	{
		///UserCodeRegionStart:[SetMenuData] (do not remove this comment.)
		this.MenuData = data;		
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	// Databinding for property MenuData
	this.GetMenuData = function()
	{
		///UserCodeRegionStart:[GetMenuData] (do not remove this comment.)
		return this.MenuData;		
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	// Databinding for property SelectedItem
	this.GetSelectedItem = function()
	{
		///UserCodeRegionStart:[GetSelectedItem] (do not remove this comment.)
		return this.SelectedItem;
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	// Databinding for property SelectedItem
	this.SetSelectedItem = function(data)
	{
		///UserCodeRegionStart:[SetSelectedItem] (do not remove this comment.)
		this.SelectedItem = data;
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}

	this.show = function()
	{
		///UserCodeRegionStart:[show] (do not remove this comment.)
		var buffer = '<div id="dolphincontainer">' //open main dolphin container
		buffer += '<div id="dolphinnav">'
		buffer += '<ul>'
		
		var i = 0;
		for (i=0;this.MenuData[i]!=undefined;i++)
		{
			buffer += '<li><a href="'+ this.MenuData[i].MenuURL +'" rel="' + this.MenuData[i].MenuDescription + '" onclick="' + this.me() + '.JSDolphinItemClicked(\'' + this.ControlName + '\',' + i +');" title="' + this.MenuData[i].MenuDescription + '"><span>' + this.MenuData[i].MenuTitle + '</span></a></li>'
		}
		buffer += '</ul>'
		buffer += '</div>'
		
		buffer += '<div id="dolphin_inner">'
		for (i=0;this.MenuData[i]!=undefined;i++)
		{
			buffer += '<div id="' + this.MenuData[i].MenuDescription + '" class="innercontent">' + this.MenuData[i].MenuDescription + '</div>'
		}
		buffer += '</div>'
		buffer += '</div>' //close main dolphin container
		this.setHtml(buffer);
		
		if(getCookie('"' + this.ControlName + this.MenuData[this.MenuData.length-1].MenuDescription + this.MenuData.length.toString() + '"') == null){
			dolphintabs.init("dolphinnav", 0);	
		}else{
			dolphintabs.init("dolphinnav", parseInt(getCookie('"' + this.ControlName + this.MenuData[this.MenuData.length-1].MenuDescription + this.MenuData.length.toString() + '"')));		
		}
		
		///UserCodeRegionEnd: (do not remove this comment.)
	}
	///UserCodeRegionStart:[User Functions] (do not remove this comment.)
	this.JSDolphinItemClicked = function(ControlName, index)
	{
		setCookie('"' + ControlName + this.MenuData[this.MenuData.length-1].MenuDescription + this.MenuData.length.toString() + '"',index,null,"/");
		
	    this.SetSelectedItem(this.MenuData[index]);
	    this.DolphinItemClicked();
	}
	
	//function getCookie(name)
	//name - name of the cookie 
	function getCookie(name)
	{
  		var cname = name + "=";               
  		var dc = document.cookie;             
  		if (dc.length > 0) {              
    		begin = dc.indexOf(cname);       
    		if (begin != -1) {           
      			begin += cname.length;       
      			end = dc.indexOf(";", begin);
      			if (end == -1) end = dc.length;
        			return unescape(dc.substring(begin, end));
    		} 
		}
		return null;
  	}
	
	//function setCookie(name, value, expires, path, domain, secure)
	//name - name of the cookie 
	//value - value of the cookie 
	//[expires] - expiration date of the cookie (defaults to end of current session) 
	//[path] - path for which the cookie is valid (defaults to path of calling document) 
	//[domain] - domain for which the cookie is valid (defaults to domain of calling document) 
	//[secure] - Boolean value indicating if the cookie transmission requires a secure transmission 
	function setCookie(name, value, expires, path, domain, secure) {
  		document.cookie = name + "=" + escape(value) + 
  		((expires == null) ? "" : "; expires=" + expires.toGMTString()) +
  		((path == null) ? "" : "; path=" + path) +
  		((domain == null) ? "" : "; domain=" + domain) +
  		((secure == null) ? "" : "; secure");
	}
	
	///UserCodeRegionEnd: (do not remove this comment.):
}
