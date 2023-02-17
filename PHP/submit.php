<?php
$formData = array(
  "name" => $_POST["name"],
  "email" => $_POST["email"],
  "password" => $_POST["password"],
);

$jsonData = json_encode($formData);
file_put_contents("form_data.json", $jsonData);
?>

