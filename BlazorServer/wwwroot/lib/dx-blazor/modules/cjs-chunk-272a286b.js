_dxBlazorInternal.define("cjs-chunk-272a286b.js",function(n,t,e){var r={ClearTimer:function(n){return n>-1&&window.clearTimeout(n),-1},ClearInterval:function(n){return n>-1&&window.clearInterval(n),-1},Throttle:function(n,t){var e,r=!1,i=this;function l(){if(r)return e=arguments,i=this,void 0;n.apply(this,arguments),r=!0,setTimeout(function(){r=!1,e&&(l.apply(i,e),e=null)},t)}return l.cancel=function(){clearTimeout(t),t=e=i=null},l}};e.Timer=r},[]);
