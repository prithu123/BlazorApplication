var o={};function e(){if(document.compatible)for(var o=0;o<document.compatible.length;o++)if("IE"===document.compatible[o].userAgent&&document.compatible[o].version)return document.compatible[o].version.toLowerCase();return""}function r(o){var e=-1,r="";return o[1]&&(r+=o[1],o[2]&&(r+="."+o[2])),""!=r&&(e=parseFloat(r),isNaN(e)&&(e=-1)),e}function a(o,e){return r(new RegExp(e,"i").exec(o))+4}function i(o,e,i,n){var t=r(e);if(n){var d=a(o,i);if("edge"===n||parseInt(n)===d)return d}return t}function n(e,r,a,i,n){for(var t=0;t<e.length;t++){var d=e[t];o[d]=d==r}o.Version=Math.floor(10*a)/10,o.MajorVersion=Math.floor(o.Version),o.WindowsPlatform="Win"==i||"WinPhone"==i,o.MacOSPlatform="Mac"==i,o.MacOSMobilePlatform="MacMobile"==i,o.AndroidMobilePlatform="Android"==i,o.WindowsPhonePlatform="WinPhone"==i,o.WebKitFamily=o.Safari||o.Chrome||o.Opera&&o.MajorVersion>=15,o.NetscapeFamily=o.Netscape||o.Mozilla||o.Firefox,o.HardwareAcceleration=o.IE&&o.MajorVersion>=9||o.Firefox&&o.MajorVersion>=4||o.AndroidMobilePlatform&&o.Chrome||o.Chrome&&o.MajorVersion>=37||o.Safari&&!o.WindowsPlatform||o.Edge||o.Opera&&o.MajorVersion>=46,o.WebKitTouchUI=o.MacOSMobilePlatform||o.AndroidMobilePlatform;var s=o.IE&&o.MajorVersion>9&&o.WindowsPlatform&&o.UserAgent.toLowerCase().indexOf("touch")>=0;if(o.MSTouchUI=s||o.Edge&&!!window.navigator.maxTouchPoints,o.TouchUI=o.WebKitTouchUI||o.MSTouchUI,o.MobileUI=o.WebKitTouchUI||o.WindowsPhonePlatform,o.AndroidDefaultBrowser=o.AndroidMobilePlatform&&!o.Chrome,o.AndroidChromeBrowser=o.AndroidMobilePlatform&&o.Chrome,n&&(o.SamsungAndroidDevice=n),o.MSTouchUI){var c=o.UserAgent.toLowerCase().indexOf("arm;")>-1;o.VirtualKeyboardSupported=c||o.WindowsPhonePlatform}else o.VirtualKeyboardSupported=o.WebKitTouchUI;!function(e){for(var r="",a=e.concat(["WindowsPlatform","MacOSPlatform","MacOSMobilePlatform","AndroidMobilePlatform","WindowsPhonePlatform","WebKitFamily","WebKitTouchUI","MSTouchUI","TouchUI","AndroidDefaultBrowser","MobileUI"]),i=0;i<a.length;i++){var n=a[i];o[n]&&(r+="dx"+n+" ")}r+="dxBrowserVersion-"+o.MajorVersion,document&&document.documentElement&&(""!=document.documentElement.className&&(r=" "+r),document.documentElement.className+=r,o.Info=r)}(e)}o.UserAgent=navigator.userAgent.toLowerCase(),o.Mozilla=!1,o.IE=!1,o.Firefox=!1,o.Netscape=!1,o.Safari=!1,o.Chrome=!1,o.Opera=!1,o.Edge=!1,o.Version=void 0,o.MajorVersion=void 0,o.WindowsPlatform=!1,o.MacOSPlatform=!1,o.MacOSMobilePlatform=!1,o.AndroidMobilePlatform=!1,o.PlaformMajorVersion=!1,o.WindowsPhonePlatform=!1,o.AndroidDefaultBrowser=!1,o.AndroidChromeBrowser=!1,o.SamsungAndroidDevice=!1,o.WebKitTouchUI=!1,o.MSTouchUI=!1,o.TouchUI=!1,o.WebKitFamily=!1,o.NetscapeFamily=!1,o.HardwareAcceleration=!1,o.VirtualKeyboardSupported=!1,o.Info="",function(r,t){var d=["Mozilla","IE","Firefox","Netscape","Safari","Chrome","Opera","Opera10","Edge"],s={Safari:2,Chrome:.1,Mozilla:1.9,Netscape:8,Firefox:2,Opera:9,IE:6,Edge:12};if(!r||0==r.length)return n(d,"IE",s.IE,"Win"),void 0;!function(e){var r=/(?:(?:windows nt|macintosh|mac os|cpu os|cpu iphone os|android|windows phone|linux) )(\d+)(?:[-0-9_.])*/.exec(e);r&&(o.PlaformMajorVersion=r[1])}(r=r.toLowerCase());try{for(var c,l={Windows:"Win",Macintosh:"Mac","Mac OS":"Mac",Mac_PowerPC:"Mac","cpu os":"MacMobile","cpu iphone os":"MacMobile",Android:"Android","!Windows Phone":"WinPhone","!WPDesktop":"WinPhone","!ZuneWP":"WinPhone"},m="(?:"+(u="(\\d+)(?:\\.((?:\\d+?[1-9])|\\d)0*?)?")+")?",f={Safari:"applewebkit(?:.*?(?:version/"+u+"[\\.\\w\\d]*?(?:\\s+mobile/\\S*)?\\s+safari))?",Chrome:"(?:chrome|crios)(?!frame)(?:/|\\s*)?"+m,Mozilla:"mozilla(?:.*rv:"+m+".*Gecko)?",Netscape:"(?:netscape|navigator)\\d*/?\\s*"+m,Firefox:"firefox(?:/|\\s*)?"+m,Opera:"(?:opera|sopr)(?:/|\\s*)?"+m,Opera10:"opera.*\\s*version(?:/|\\s*)?"+m,IE:"msie\\s*"+m,Edge:"edge(?:/|\\s*)?"+m},u=-1,M=0;M<d.length;M++){var h=d[M],p=new RegExp(f[h],"i");if(p.compile&&p.compile(f[h],"i"),(A=p.exec(r))&&A.index>=0){if("IE"==c&&u>=11&&"Safari"==h)continue;"Opera10"==(c=h)&&(c="Opera"),u=i(r,A,"trident(?:/|\\s*)?"+m,e()),"Mozilla"==c&&u>=11&&(c="IE")}}c||(c="IE");var P,b=-1!=u;b||(u=s[c]);var w=Number.MAX_VALUE;for(var W in l)if(l.hasOwnProperty(W)){var I="!"==W.substr(0,1),v=r.indexOf((I?W.substr(1):W).toLowerCase());v>=0&&(v<w||I)&&(w=I?0:v,P=l[W])}var A,g=(A=r.toUpperCase().match("SM-[A-Z]"))&&A.length>0;"WinPhone"==P&&u<9&&(u=Math.floor(a(r,"trident(?:/|\\s*)?"+m))),!t&&"IE"==c&&u>7&&document.documentMode<u&&(u=document.documentMode),"WinPhone"==P&&(u=Math.max(9,u)),P||(P="Win"),P!=l["cpu os"]||b||(u=4),n(d,c,u,P,g)}catch(o){n(d,"IE",s.IE,"Win")}}(o.UserAgent);export{o as B};
