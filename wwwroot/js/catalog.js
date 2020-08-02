
function fetchData(){
    $.ajax({
        url: "/catalog/getCatalog",
        type: "GET",
        success: function(data){
            console.log("Server Responded with ", data);

            // Travel the array
            // get each property
            // display property in html
        },
        error: function(details){
            console.log("Error ", details);
        }
    })
}



function init(){
    console.log("Catalog Page");
}

window.onload = init;