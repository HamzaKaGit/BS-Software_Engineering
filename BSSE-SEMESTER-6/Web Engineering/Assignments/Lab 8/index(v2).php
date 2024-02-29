<!DOCTYPE html>
<html>
<head>
	<title>Rectangle Calculator</title>
</head>
<body>
	<h1>Rectangle Calculator</h1>
	<form method="post">
		<label for="length">Length:</label>
		<input type="number" name="length" id="length" required><br><br>
		<label for="width">Width:</label>
		<input type="number" name="width" id="width" required><br><br>
		<input type="submit" name="submit" value="Calculate"><br><br>
	</form>
	<?php
	if (isset($_POST['submit'])) {
		$length = $_POST['length'];
		$width = $_POST['width'];
		$area = $length * $width;
		$perimeter = 2 * ($length + $width);
		echo "<h3>Results:</h3>";
		echo "Area: " . $area . "<br>";
		echo "Perimeter: " . $perimeter;
	}
	?>
</body>
</html>