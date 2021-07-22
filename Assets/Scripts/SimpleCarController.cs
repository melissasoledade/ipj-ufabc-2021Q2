// Código visto na documentação do Unity (link abaixo) sobre criação de carrinho simples de corrida
// https://docs.unity3d.com/Manual/WheelColliderTutorial.html
// Cria-se uma base para o player (Cube) com algumas rodas personalizadas posteriormente com o Wheel Collider
// Colocamos o personagem (dinossauro) como "filho" de Cube para movimentar-se

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
    
public class SimpleCarController : MonoBehaviour {
    public List<AxleInfo> axleInfos; // informação sobre cada eixo
    public float maxMotorTorque; // torque máximo aplicado na roda
    public float maxSteeringAngle; // ângulo máximo de direção que uma roda pode ter
        
    public void FixedUpdate()
    {
        float motor = maxMotorTorque * Input.GetAxis("Vertical");
        float steering = maxSteeringAngle * Input.GetAxis("Horizontal");
            
        foreach (AxleInfo axleInfo in axleInfos) {
            if (axleInfo.steering) {
                axleInfo.leftWheel.steerAngle = steering;
                axleInfo.rightWheel.steerAngle = steering;
            }
            if (axleInfo.motor) {
                axleInfo.leftWheel.motorTorque = motor;
                axleInfo.rightWheel.motorTorque = motor;
            }
        }
    }
}
    
[System.Serializable]
public class AxleInfo {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // esta roda está presa ao motor?
    public bool steering; // esta roda aplica o ângulo de direção?
}