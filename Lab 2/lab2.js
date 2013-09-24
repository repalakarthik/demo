//Function to conver Celsius to Farenheit
function convert(degree)
{
if (degree=="C")
 {
 F=document.getElementById("c").value * 9 / 5 + 32;
 document.getElementById("f").value=Math.round(F);
 }
else	
 {
 C=(document.getElementById("f").value -32) * 5 / 9;
 document.getElementById("c").value=Math.round(C);
 }
}
//Function to display directions.
var directionDisplay;
var directionsService = new google.maps.DirectionsService();     
var map;
function initialize()
{
            directionsDisplay = new google.maps.DirectionsRenderer();        
    var center = new google.maps.LatLng(0, 0);    
    var myOptions =
    {
            zoom:7,
            mapTypeId: google.maps.MapTypeId.ROADMAP,
            center: center
    }
    map = new google.maps.Map(document.getElementById("map_canvas"), myOptions);
    directionsDisplay.setMap(map);
    var start = "Hyderabad"; 
    var end = "Delhi";  
    var request =
    {
            origin:start,
            destination:end,
            travelMode: google.maps.DirectionsTravelMode.DRIVING         
    };
    directionsService.route(request, function(response, status)
    {
            if (status == google.maps.DirectionsStatus.OK) 
            {
            directionsDisplay.setDirections(response);      
            }
    });
}
