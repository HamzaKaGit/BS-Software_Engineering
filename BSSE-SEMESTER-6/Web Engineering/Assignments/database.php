<?php


// Data Configuration
$servername = "127.0.0.1:3307";   // Replace with your server name if not using localhost
$username1 = "root";         // Replace with your MySQL username
$password1 = "";             // Replace with your MySQL password
$dbname = "jibran123";   // Replace with your database name

// Creat Connection
$conn = new mysqli($servername, $username1, $password1, $dbname);

// Check Connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
}

?>