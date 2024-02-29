<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
    echo "<h1>","Hello World!","</h1>";

    // Get the registration data from the form
    if ($_SERVER["REQUEST_METHOD"] == "POST"){
        $username = $_POST['name'];
        $email = $_POST['email'];
        $password = $_POST['password'];
        $error = array();  // declare data type of array
/*
        if (empty ($username) || empty($email) || empty($password)){
            array_push($errors, "All fields are required.");
        }
        if (!filter_var($email, FILTER_VALIDATE_EMAIL)){
            array_push($errors, "Email is invalid");

        }
        if (count($errors) > 0){
            foreach ($errors as $error){
                echo $error:
            }
        }else{  */
            require_once "database.php";
            
//            $hashedPassword = password_hash($password, PASSWORD_DEFAULT);

            $sql = "INSERT INTO jibran111 (Name, Email, Password) VALUES ('$username', '$email', '$password')";

           if ($conn->query($sql) === TRUE) {
                 echo "Registration Successful!<br>";
                 echo "Username: $username<br>";
                 echo "Email: $email<br>";


            }else{
                echo "Error: " .$sql . "<br>" . $conn->error;
            }
            
    }
    ?>

<form action="index.php" method="POST">

        <label for="fname">Name</label>
        <input type="text" id="name" name="name" value=""><br>

        <label for="fname">Email:</label>
        <input type="email" id="email" name="email" value=""><br>

        <label for="fname">Password:</label>
        <input type="password" id="password" name="password" value=""><br>

        <button type="submit">Register</button>

    </form>

</body>
</html>