using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour 
{
	

	public void LogoutBtn(string Login)
	{
		SceneManager.LoadScene (Login);
	}

	public void ExitBtn()
	{
		Application.Quit();
	}

	public void CreateBtn(string BrawlMain)
	{
		SceneManager.LoadScene (BrawlMain);
	}

	public void ConnectBtn(string Connect)
	{
		SceneManager.LoadScene (Connect);
	}

	public void LoginBtn(string Login)
	{
		SceneManager.LoadScene (Login);
	}

	public void CreateAccBtn(string Create)
	{
		SceneManager.LoadScene (Create);
	}
		

}
