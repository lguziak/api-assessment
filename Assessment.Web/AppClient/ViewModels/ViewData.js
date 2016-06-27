$(function () {

    var $display = $("#uldisplay");
   // $display.append('<h2> Hello World </h2>');

    $.ajax(
      {
          type: 'GET',
          url: '/api/assessment',
          success: function (data) {
              console.log('success', data);

              $display.append('<li> message from server on load: ' + data + '</li>');

          },
          error: function () {
              alert("error loading JSON");
          }
      });

   
    $("#id").on("click", function() {


    });

    $("#Button1").on("click", function () {

        $.ajax(
        {
            type: 'GET',
            url: '/api/assessment',
              success: function(data) {
                  console.log('success', data);

                      $display.append('<li> message from server on request: ' + data + '</li>');
            
              },
              error: function() {
                  alert("error loading JSON");
              }
        });

    });
  

});