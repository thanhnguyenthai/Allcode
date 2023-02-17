
     var xmlHttp = createXmlHttpRequestObject()

        function createXmlHttpRequestObject() {
            var xmlHttp;

            if (window.ActiveXObject) {
                try {
                    xmlHttp = new ActiveXObject("Microsoft.XMLHTTP");
                } catch (e) {
                    xmlHttp = false;
                }
            } else {
                try {
                    xmlHttp = new XMLHttpRequest();
                } catch (e) {
                    xmlHttp = false;
                }
            }

            if (!xmlHttp)
                alert("cant create that object hoss!");
            else
                return xmlHttp;
        }

        function process() {
           // alert("1st checkpoint f(process) - readyState: " + xmlHttp.readyState);//
            if (xmlHttp.readyState == 0 || xmlHttp.readyState == 4) {
              //  alert("2nd checkpoint f(process) - readyState: " + xmlHttp.readyState);//
                sport = encodeURIComponent(document.getElementById("userInput").value);
                xmlHttp.open("GET", "sport.php?sport=" + sport, true);
                xmlHttp.onreadystatechange = handleServerResponse;
                xmlHttp.send(null);
            } else {
                setTimeout('process()', 1000);
            }
        }

        function handleServerResponse() {
            // alert("1st checkpoint f(handleServerResponse) - readyState: " + xmlHttp.readyState);//
            if (xmlHttp.readyState == 4) {
             //   alert("2nd checkpoint f(handleServerResponse) - readyState: " + xmlHttp.readyState);//
                if (xmlHttp.status == 200) {
                    xmlReponse = xmlHttp.responseXML;
                    xmlDocumentElement = xmlReponse.documentElement;
                    message = xmlDocumentElement.firstChild.data;
                    document.getElementById("underInput").innerHTML = message;
                    setTimeout('process()', 1000);
                } else {
                    alert('Something went wrong!');
                }
            }
        }
