<?php
header('Content-Type: text/xml');
echo '<?xml version="1.0" encoding="UTF-8" standalone="yes" ?>';

echo '<response>';

    $sport =  $_GET['sport'];
    $sportArray = array("SOCCER", "BASKETBALL", "TENNIS", "GOLF", "SWIMMING", "ALTHETICS");
   
    if(in_array($sport,$sportArray))
        echo 'You like '.$sport.'!';

    elseif($sport=='') 
        echo 'You like: ' ;
    else 
        echo 'Sorry it is not on the list '.$sport.'!';

        

    
echo '</response>';

?>

