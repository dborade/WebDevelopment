#pragma checksum "C:\Users\darsh\Documents\GitHub\DarshanaDotNet\CoffeeBooking\CoffeeBook\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e44e6c32ad6d22a10f172405296b357b477a0871"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(CoffeeBooking.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Index.cshtml", typeof(CoffeeBooking.Pages.Pages_Index), null)]
namespace CoffeeBooking.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\darsh\Documents\GitHub\DarshanaDotNet\CoffeeBooking\CoffeeBook\Pages\_ViewImports.cshtml"
using CoffeeBooking;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e44e6c32ad6d22a10f172405296b357b477a0871", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07f50a5e18a50ca5b5dec9f7946a41677d1f9df2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\darsh\Documents\GitHub\DarshanaDotNet\CoffeeBooking\CoffeeBook\Pages\Index.cshtml"
  
    ViewData["Title"] = "Welcome to the page";

#line default
#line hidden
            BeginContext(83, 701, true);
            WriteLiteral(@"
<link rel=""stylesheet"" type=""text/css"" href=""https://js.api.here.com/v3/3.0/mapsjs-ui.css?dp-version=1533195059"" />
<h1>Find the Best Cup of Coffee in Town</h1>
<div><div id=""map"" style=""width: 40%; height: 400px; background: grey"" /></div>
<span class=""pull-right"">&nbsp;&nbsp;</span>
<h2>Choose from below destinations</h2>
<div><ul id=""RestauantList""></ul></div>

<style>
    body {
    background-image: url(""http://yesofcorsa.com/wp-content/uploads/2017/02/Coffee-Desktop-Wallpaper-HD.jpg"") ;
    background-color: #cccccc;
    background-attachment: fixed;
    width: 100%;
    color: white;
    background-size: cover;
    font-family: 'Sniglet', cursive;
 }


</style>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(802, 14530, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://js.api.here.com/v3/3.0/mapsjs-core.js""></script>
    <script type=""text/javascript"" src=""https://js.api.here.com/v3/3.0/mapsjs-service.js""></script>
    <script type=""text/javascript"" src=""https://js.api.here.com/v3/3.0/mapsjs-ui.js""></script>
    <script type=""text/javascript"" src=""https://js.api.here.com/v3/3.0/mapsjs-mapevents.js""></script>
    <script src=""https://cdn.jsdelivr.net/npm/vue/dist/vue.js""></script>

    <script>
        
        $(function() {
            getLocation();
            loadData();
        });

        function loadData() {   
            $.ajax({
                url: 'http://localhost:5000/api/Restaurants',
                dataType: 'json',
                contentType: 'application/json',
                method: 'GET'
            }).done(function(responseJSON,status,xhr) {
                
                buildRestuarant(responseJSON);
            }).fail(function(xhr,status,error) {
                
      ");
                WriteLiteral(@"          alert(""There was an error retrieving the data"");
            });
        }

            $(""#RestauantList"").on('click', 'a.bookTable', function() {
            $(this).parents(""li"").find('.bookThisTable-form').show();
            return false;
            }); 

            $(""#RestauantList"").on('click', 'button.bookTable-cancel', function() {
            $(this).parents(""li"").find('.bookThisTable-form').hide();
            return false;
            });    
            
            $(""#RestauantList"").on('click', 'button.bookTable-save', function() {
            var id = $(this).parents(""li"").attr('restuarant-id');
            var tableid = $(this).parents(""li"").find('.bookThisTable-form #tablesDropdown'+id).val();
            var firstName = $(this).parents(""li"").find('.bookThisTable-form .firstName').val();
            var lastName = $(this).parents(""li"").find('.bookThisTable-form .lastName').val();
            var contactNum = $(this).parents(""li"").find('.bookThisTable-form .co");
                WriteLiteral(@"ntactNum').val();
            var emailId = $(this).parents(""li"").find('.bookThisTable-form .emailId').val();
            RegisterCustomer(firstName, lastName, contactNum, emailId, tableid, function(){
                return false;
            });    
        });

        function RegisterCustomer(firstName,lastName, contactNum, emailId, tableid, callback) {
                var requestData1 = {
                  firstName:firstName,
                  lastName: lastName,
                  contactNo : contactNum,
                  email : emailId,
                  tableId: tableid
                 };
                var errors ={
                  firstName:"""",
                  lastName: """",
                  contactNo : """",
                  email : """",
                  tableId: """"
                 };
            $.ajax({
                url: 'http://localhost:5000/api/Customers/',
                dataType: 'json',
                contentType: 'application/json',
                me");
                WriteLiteral(@"thod: 'POST',
                data: JSON.stringify(requestData1)
            }).done(function(responseData, status, xhr) {
                loadData(); 
                
            if (callback) {
                callback();
                }
            }).fail(function(xhr, status, error) {
                if (xhr.status == 400) {
                    $('.text-danger').empty();
                    errors=xhr.responseJSON;
                    if(errors.firstName != null){
                        $("".firstName"").after('<span class=""text-danger"">'+errors.firstName+'</span>');
                    }
                    if(errors.lastName != null){
                        $("".lastName"").after('<span class=""text-danger"">'+errors.lastName+'</span>');
                    }
                    if(errors.contactNum != null){
                        $("".contactNum"").after('<span class=""text-danger"">'+errors.contactNo+'</span>');
                    }
                    if(errors.email != null){
  ");
                WriteLiteral(@"                      $("".email"").after('<span class=""text-danger"">'+errors.email+'</span>');
                    }
                }
            });
        }  

            function bookThisTable(id,firstName,callback) {
                var requestData = {
                //timeofBooking: ""3PM"",
                //dateofBooking: ""12/2/2018"",
                  assignedto:firstName,
                 };
            $.ajax({
                url: 'http://localhost:5000/api/Tables/loan' + id,
                dataType: 'json',
                contentType: 'application/json',
                method: 'PUT',
                data: JSON.stringify(requestData)
            }).done(function(responseData, status, xhr) {
                loadData(); 
                alert(status);
            if (callback) {
                callback();
                }
            }).fail(function(xhr, status, error) {
                
                alert(""There was an error booking your table""+error.stringify()+""");
                WriteLiteral(@"&    &""+status.stringify()+""&   &""+xhr.stringify());
            });
        }  

        function buildRestuarant(restaurantList){
            $(""#RestauantList"").empty();
            $.each(restaurantList,function(index,item){
                var listOfRestuarants = $('<li restuarant-id=""'+item.id+'""></li>');
                $(listOfRestuarants).html('<div><h3>'+item.name+'</h3><div>Opens at: '+item.openingTime+' Closes at: '+item.closingTime+'</div><div>'+item.priceRange+'</div><a href=""#"" class=""bookTable"">Book your coffee </a></div>');
               var Xlat =item.latitude;
               var Xlong=item.longitude;
                addLocation(Xlat,Xlong,item.name);
              
               var bookThisTableForm = $('<div style=""display: none;"" class=""row bookThisTable-form""></div>');
               var bookTableInput = $('<select class=""form-control"" id=tablesDropdown'+item.id+' name=tablesDropdown""'+item.id+'""><input type=""text"" class=""form-control firstName"" placeholder=""Please enter");
                WriteLiteral(@" your first Name"" /><input type=""text"" class=""form-control lastName"" placeholder=""Please enter your last name"" /><input type=""text"" class=""form-control contactNum"" placeholder=""Please enter your contact no."" /><input type=""text"" class=""form-control emailId"" placeholder=""Please enter your email id"" /></div>');
               var bookTablebutton = $('<div class=""col-sm-4""><button class=""btn btn-primary bookTable-save"">Book this table</button> <button class=""btn btn-default bookTable-cancel"">Cancel</button></div>');
               var s = '<option value=""-1"">Please Select number of people</option>';  
               $.get(""http://localhost:5000/api/Tables/loan/"" +item.id, function(value, data){
                    $.each(value, function(key, item){
                        s += '<option value=""' + value[key].id + '"">' + ""Table-""+value[key].tableNumber  + ""("" +value[key].tableType+"")""+'</option>';
                    });
                    
                    $('#tablesDropdown'+item.id).html(s);
      ");
                WriteLiteral(@"          
                 });   
               $(bookThisTableForm).append(bookTableInput);
               $(bookThisTableForm).append(bookTablebutton);
               $(listOfRestuarants).append(bookThisTableForm);
               $(""#RestauantList"").append(listOfRestuarants);
                
            });
        } 


         //GEolocation APi's 
          //Center to user's current location
        function moveMapToCurrentLocation(map,Xlat,Xlong) {
            map.setCenter({ lat: Xlat, lng: Xlong });
            map.setZoom(14);
          }



          //Add marker to the location
          function addMarkersToMap(map, Xlat, Xlong) {
              var parisMarker = new H.map.Marker({ lat: Xlat, lng: Xlong });
              map.addObject(parisMarker);
          }
         
          
       //Step 1: initialize communication with the platform
        var platform = new H.service.Platform({
            app_id: 'devportal-demo-20180625',
            app_code: '9v2BkviRw");
                WriteLiteral(@"i9Ot26kp2IysQ',
            useHTTPS: true
        });
        var pixelRatio = window.devicePixelRatio || 1;
        var defaultLayers = platform.createDefaultLayers({
            tileSize: pixelRatio === 1 ? 256 : 512,
            ppi: pixelRatio === 1 ? undefined : 320
        });

        //Step 2: initialize a map  - not specificing a location will give a whole world view.
        var map = new H.Map(document.getElementById('map'),
            defaultLayers.normal.map, { pixelRatio: pixelRatio });

        //Step 3: make the map interactive
        // MapEvents enables the event system
        // Behavior implements default interactions for pan/zoom (also on mobile touch environments)
        var behavior = new H.mapevents.Behavior(new H.mapevents.MapEvents(map));

        // Create the default UI components
        var ui = H.ui.UI.createDefault(map, defaultLayers);

        //var x = document.getElementById(""demo"");
        function getLocation() {
            if (navigator.geolo");
                WriteLiteral(@"cation) {
                navigator.geolocation.getCurrentPosition(showPosition);
            } else {
                alert(""Geolocation is not supported by this browser."");
            }
        }
           


          function showPosition(position) {
              //alert(""Currently you are here"")
              // Now use the map as required...
              
             var xlat = position.coords.latitude;
             var xlong = position.coords.longitude;
             function getUserPosition(xlat,xlong)
            {
                 var returnedObject = {};
                returnedObject[""value1""] = xlat;
                returnedObject[""value2""] = value2;
                        return xlong;
            }
              moveMapToCurrentLocation(map, xlat, xlong);
              var circle = new H.map.Circle({ lat: xlat, lng: xlong }, 1500);
              map.addObject(circle);
              var icon = new H.map.Icon('https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSxp");
                WriteLiteral(@"tK5F9I0F4dK7aqV54GqeRAIL6crHDEVqRLtZFP1MVFhJah0rA', { size: { w: 32, h: 32 } });
              // Create a marker using the previously instantiated icon:
              var marker = new H.map.Marker({ lat: xlat, lng: xlong }, { icon: icon });
              // Add the marker to the map:
              map.addObject(marker);
              }     

            function addLocation(xlat, xlong,name) {
            
              var icon = new H.map.Icon('https://cdn3.iconfinder.com/data/icons/maps-and-navigation-7/65/65-512.png', { size: { w: 40, h: 40 } });
              // Create a marker using the previously instantiated icon:
              var marker = new H.map.Marker({ lat: xlat, lng: xlong }, { icon: icon });
              tooltip = new Tooltip(map);
              marker.title = '<div>'+name+'</div>';
              // Add the marker to the map:
              map.addObject(marker);
            }       


          
         (function (ctx) {
              // ensure CSS is injected
       ");
                WriteLiteral(@"       var tooltipStyleNode = ctx.createElement('style'),
                  css = '#nm_tooltip{' +
                      ' color:black;' +
                      ' background:white;' +
                      ' border: 1px solid grey;' +
                      ' padding-left: 1em; ' +
                      ' padding-right: 1em; ' +
                      ' display: none;  ' +
                      ' min-width: 120px;  ' +
                      '}';

              tooltipStyleNode.type = 'text/css';
              if (tooltipStyleNode.styleSheet) { // IE
                  tooltipStyleNode.styleSheet.cssText = css;
              } else {
                  tooltipStyleNode.appendChild(ctx.createTextNode(css));
              }
              if (ctx.body) {
                  ctx.body.appendChild(tooltipStyleNode);
              } else if (ctx.addEventListener) {
                  ctx.addEventListener('DOMContentLoaded', function () {
                      ctx.body.appendChild(tooltipStyleNode);
   ");
                WriteLiteral(@"               }, false);
              } else {
                  ctx.attachEvent('DOMContentLoaded', function () {
                      ctx.body.appendChild(tooltipStyleNode);
                  });
              }
          })(document);


          Object.defineProperty(Tooltip.prototype, 'visible', {
              get: function () {
                  return this._visible;
              },
              set: function (visible) {
                  this._visible = visible;
                  this.tooltip.style.display = visible ? 'block' : 'none';
              }
          });


          function Tooltip(map) {
              var that = this;
              that.map = map;
              that.tooltip = document.createElement('div');
              that.tooltip.id = 'nm_tooltip';
              that.tooltip.style.position = 'absolute';
              obj = null,
                  showTooltip = function () {
                      var point = that.map.geoToScreen(obj.getPosition()),
    ");
                WriteLiteral(@"                      left = point.x - (that.tooltip.offsetWidth / 2),
                          top = point.y + 1; // Slight offset to avoid flicker.
                      that.tooltip.style.left = left + 'px';
                      that.tooltip.style.top = top + 'px';
                      that.visible = true;
                      that.tooltip.innerHTML = obj.title;
                  };


              map.getElement().appendChild(that.tooltip);
              map.addEventListener('pointermove', function (evt) {
                  obj = that.map.getObjectAt(evt.currentPointer.viewportX,
                      evt.currentPointer.viewportY);
                  if (obj && obj.title) {
                      showTooltip();
                  } else {
                      that.visible = false;
                  }
              });

              map.addEventListener('tap', function (evt) {
                  that.tooltip.visible = false;
              });
              map.addEventListener('dra");
                WriteLiteral("g\', function (evt) {\r\n                  if (that.visible) {\r\n                      showTooltip();\r\n                  }\r\n              });\r\n          };\r\n\r\n\r\n        \r\n    \r\n    \r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(15335, 2, true);
            WriteLiteral("\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
