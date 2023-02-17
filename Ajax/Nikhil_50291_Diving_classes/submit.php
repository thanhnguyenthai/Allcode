<?php
$formData = array(
  "name" => $_POST["name"],
  "email" => $_POST["email"],
  "studentid" => $_POST["studentid"],
  "input" => $_POST["input"],
);

$jsonData = json_encode($formData);
file_put_contents("form_data.json", $jsonData);
?>

