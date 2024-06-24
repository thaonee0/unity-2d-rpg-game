using UnityEngine;
using UnityEngine.SceneManagement;

public class Main_menu : MonoBehaviour
{
    // Phương thức này được gán vào sự kiện onClick của button trong Inspector
    public void LoadNextScene()
    {
        // Lấy index của scene hiện tại và tăng lên 1 để lấy index của scene tiếp theo
        int nextSceneIndex = SceneManager.GetActiveScene().buildIndex + 1;

        // Kiểm tra nếu nextSceneIndex vượt quá số lượng scene trong build settings thì quay lại scene đầu tiên
        if (nextSceneIndex >= SceneManager.sceneCountInBuildSettings)
        {
            nextSceneIndex = 0;
        }

        // Load scene mới với index đã tính toán
        SceneManager.LoadScene(nextSceneIndex);
    }

    // Phương thức Quit để thoát game
    public void Quit()
    {
        Application.Quit();
    }
}
