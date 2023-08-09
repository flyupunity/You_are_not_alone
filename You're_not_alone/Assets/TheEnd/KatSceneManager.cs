using UnityEngine;
using UnityEngine.SceneManagement;

public class KatSceneManager : MonoBehaviour
{
	public Animator BackGround;
	public GameObject[] Image;
	public int y;

	public void Next()
	{
		//BackGround.SetBool("Black", true);
		y ++;
		for(int i = 0; i <= Image.Length - 1; i++){
			Image[i].SetActive(false);
		}
		if(y < Image.Length){
			Image[y].SetActive(true);
		}else{ SceneManager.LoadScene(0);}
		//BackGround.SetBool("Black", false);
	}
	public void Menu()
	{
		SceneManager.LoadScene(0);
	}
}
