<?php 

function conectarDB() : mysqli {
    $db = new mysqli('localhost:330', 'root', '', 'bienesraices');

    if(!$db) {
        echo "Error no se pudo conectar";
        exit;
    } 

    return $db;
    
}