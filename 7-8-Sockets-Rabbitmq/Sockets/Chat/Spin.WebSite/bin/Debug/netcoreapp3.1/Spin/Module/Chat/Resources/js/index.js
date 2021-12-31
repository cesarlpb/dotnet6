var URL = 'ws://localhost:5000/ws/RT/Chat/ChatWebSocket/Connect';


$("#btnConnect").click(function(){
    let code = Math.random().toString(36).substring(7);
    webSocket = $.simpleWebSocket({ url: URL +"?id=" + code + "&name=" + $("#userName").val()  });
    
    webSocket.listen(function(message) {
        switch (message.codeResponse) {
            case 100:
                $("#users").empty();
                $.each(message.message, function(key, value){
                    $('#users').append(new Option(value, value))
                })
                break;
        
            default:
                $("#chatRecive").append("<strong>" + message.name + " Says:</strong>" + message.message[0] + "<br/>");
                break;
        }
    }).fail(function(e) {
        alert("Error Connect");
    });

    $(".disconnect").hide();
    $(".connect").show();
});

 
$("#btnSend").click(function(){

    var request = {
        CodeRequest : 100,
        Name : $( "#users option:selected" ).text() ,
        Message : $("#name").val()
    };

    webSocket.send(request).done(function(message) {
         
    }).fail(function(e) {
        alert("Send Error Connect");
    });
});


$("#btnDisconnect").click(function(){
    webSocket.close();

    $(".disconnect").show();
    $(".connect").hide();
});

