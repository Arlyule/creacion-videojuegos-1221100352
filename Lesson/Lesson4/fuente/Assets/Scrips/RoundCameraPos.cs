using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RoundCameraPos : CinemachineExtension
{
    // Define los píxeles por unidad para lograr un efecto de cámara en "pixel-perfect".
    public float PixelsPerUnit = 32;

    // Método que se llama en cada etapa del pipeline de Cinemachine.
    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state,
        float deltaTime)
    {
        // Solo aplica el ajuste cuando la etapa actual es "Body".
        if (stage == CinemachineCore.Stage.Body)
        {
            Vector3 pos = state.FinalPosition; // Posición actual de la cámara.
            Vector3 pos2 = new Vector3(Round(pos.x), Round(pos.y), pos.z); // Posición ajustada.

            // Aplica la corrección de posición.
            state.PositionCorrection += pos2 - pos;
        }
    }

    // Redondea una posición dada según los píxeles por unidad.
    float Round(float x)
    {
        return Mathf.Round(x * PixelsPerUnit) / PixelsPerUnit;
    }
}
