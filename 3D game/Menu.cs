using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; //подключаем билиотеку для работы со сценами

public class Menu : MonoBehaviour
{
    //создаём новую команду для старта игры
    public void PlayGame()
    {
        SceneManager.LoadScene(1);//загружаем первую сцену 
        // 0 - меню, 1 - уровень
    }
    public void QuitGame()
    {
        Application.Quit(); //выход из игры
        print("выход из игры");
    }
}
