// Base URL of the WCF service
const baseUrl = "http://localhost:50336/Service1.svc"; 

// Function to encrypt a message using the WCF service
function encryptMessage() {
    let message = document.getElementById("message").value;
    let seed = document.getElementById("seed").value;

    // Ensure both message and seed are provided
    if (message === "" || seed === "") {
        alert("Please enter both message and seed.");
        return;
    }

    // Send request to encrypt the message
    fetch(`${baseUrl}/encrypt?text=${encodeURIComponent(message)}&seed=${seed}`)
        .then(response => response.text())  // Get plain text response
        .then(data => {
            document.getElementById("result").innerText = data;
        })
        .catch(error => console.error("Error:", error));
}

// Function to send the encrypted message to the receiver section
function sendToReceiver() {
    let messageToSend = document.getElementById("result").innerText;
    document.getElementById("result2").innerText = messageToSend;
}

// Function to decrypt a message using the WCF service
function decryptMessage() {
    let message = document.getElementById("result2").innerText;
    message = message.replace(/"/g, '');
    let seed = document.getElementById("seed2").value;

    // Ensure both message and seed are provided
    if (message === "" || seed === "") {
        alert("Please enter both message and seed.");
        return;
    }

    // Send request to decrypt the message
    fetch(`${baseUrl}/decrypt?text=${encodeURIComponent(message)}&seed=${seed}`)
        .then(response => response.text())  // Get plain text response
        .then(data => {
            document.getElementById("result3").innerText = data;
        })
        .catch(error => console.error("Error:", error));
}

// Function to return the decrypted message back to the sender section
function returnToSender() {
    let messageToSend = document.getElementById("result3").innerText;
    document.getElementById("result").innerText = messageToSend;
}