<?php

namespace Anax\notification;


class Cnotify{

use \Anax\DI\TInjectable;



public function insertMessage($message){
	 $_SESSION['notificationMessage'] =  "<div class='alert alert-success' role='alert'>". $message." </div>";


	
}

public function showMessage()
    {
        if(!is_null($_SESSION['notificationMessage'])) {
            echo $_SESSION['notificationMessage'];
                    $_SESSION['notificationMessage'] = null;
        }
        else{
        	
        }
        
    }






}

