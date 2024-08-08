using UnityEngine;

public class LightFlicker : MonoBehaviour
{
    public Light spotlight; // 需要控制的聚光灯
    public float minIntensity = 0.5f; // 最低光照强度
    public float maxIntensity = 2.0f; // 最高光照强度
    public float flickerSpeed = 1.0f; // 光源变化速度

    private float targetIntensity; // 目标光照强度
    private float currentChangeTime = 0.0f; // 当前变化时间

    void Start()
    {
        if (spotlight == null)
        {
            spotlight = GetComponent<Light>();
        }
        targetIntensity = spotlight.intensity;
    }

    void Update()
    {
        // 计算新的目标光照强度
        targetIntensity = Mathf.Lerp(minIntensity, maxIntensity, Mathf.PingPong(Time.time * flickerSpeed, 1));

        // 平滑过渡到新的光照强度
        spotlight.intensity = Mathf.Lerp(spotlight.intensity, targetIntensity, Time.deltaTime * flickerSpeed);
    }

    
}
