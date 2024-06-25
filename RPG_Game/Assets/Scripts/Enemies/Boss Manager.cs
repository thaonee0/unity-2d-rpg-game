using UnityEngine;

public class BossMger : MonoBehaviour
{
    public GameObject bulletPrefab;
    public Transform firePoint;
    public float fireRate = 1f;
    private float nextFireTime;

    private Transform playerTransform; // Tham chiếu đến transform của người chơi


    void Start()
    {
        // Tìm đối tượng người chơi bằng tag (cần đặt tag cho đối tượng người chơi là "Player")
        playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
    }

    void Update()
    {
        // Cập nhật vị trí của người chơi
        UpdatePlayerPosition();

        if (Time.time >= nextFireTime)
        {
            Attack();
            nextFireTime = Time.time + 1f / fireRate;
        }
    }

    void UpdatePlayerPosition()
    {
        // Kiểm tra nếu không tìm thấy người chơi
        if (playerTransform == null)
        {
            GameObject playerObject = GameObject.FindGameObjectWithTag("Player");
            if (playerObject != null)
            {
                playerTransform = playerObject.transform;
            }
        }
        else
        {
            // Cập nhật vị trí của người chơi
            playerTransform = GameObject.FindGameObjectWithTag("Player").transform;
        }
    }

    void Attack()
    {
        // Kiểm tra nếu chưa có người chơi
        if (playerTransform == null)
        {
            return;
        }

        // Hướng đạn đến vị trí của người chơi
        Vector2 fireDirection = (playerTransform.position - firePoint.position).normalized;

        // Tạo viên đạn và hướng nó
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, Quaternion.identity);
        bullet.transform.right = fireDirection;

        // Customize bullet behavior here (e.g., speed, damage)
    }

}
