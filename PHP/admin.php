<?php
$jsonData = file_get_contents("form_data.json");
$formData = json_decode($jsonData, true);

echo "<table>";
echo "<tr><th>name</th><th>email</th><th>password</th></tr>";
foreach ($formData as $data) {
  echo "<tr>";
  echo "<td>" . htmlspecialchars($data["name"]) . "</td>";
  echo "<td>" . htmlspecialchars($data["email"]) . "</td>";
  echo "<td>" . htmlspecialchars($data["password"]) . "</td>";
  echo "</tr>";
}
echo "</table>";
?>