<?php
header('Content-Type: text/xml');
echo '<?xml version="1.0" encoding="UTF-8" standalone="yes" ?>';

echo '<response>';

    $food =  $_GET['food'];
    $foodArray = array('tuna','bacon','beef','banana');
    if(in_array($food,$foodArray))
        echo 'We do have'.$food.'!';

    elseif($food=='') 
        echo 'Enter a food plz: ';
    else 
        echo 'Sorry we dont sell '.$food.'!';
    
echo '</response>';

?>

