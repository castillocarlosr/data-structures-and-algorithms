<?php
echo "Hello first php console program!";

function matchSubString($s1, $s2)
{
    $s1Len = strlen($s1);
    $s2Len = strlen($s2);
    
    $i;
    for($i = 0; $i <= $s2Len - $s1Len; $i++)
    {
        $j;
        for($j = 0; $j < $s1Len; $j++)
        {
            if($s2[$i + $j] != $s1[$j])
            break;
        }
        if($j == $s1Len)
        return "true";
    }
    return "false";
}

$str1 = "brave";
$str2 = "iwanttobebraveforcode";

/*
function showBool($myBool)
{
    return ($myBool) ? "True" : "False";
}
*/
$answer = matchSubString($str1, $str2);
echo $answer;
?>