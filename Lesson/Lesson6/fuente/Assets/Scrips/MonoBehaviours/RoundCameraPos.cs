using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class RoundCameraPos : CinemachineExtension
{
    // Define los p�xeles por unidad para lograr un efecto de c�mara en "pixel-perfect".
    public float PixelsPerUnit = 32;

    // M�todo que se llama en cada etapa del pipeline de Cinemachine.
    protected override void PostPipelineStageCallback(
        CinemachineVirtualCameraBase vcam,
        CinemachineCore.Stage stage, ref CameraState state,
        float deltaTime)
    {
        // Solo aplica el ajuste cuando la etapa actual es "Body".
        if (stage == CinemachineCore.Stage.Body)
        {
            Vector3 pos = state.FinalPosition; // Posici�n actual de la c�mara.
            Vector3 pos2 = new Vector3(Round(pos.x), Round(pos.y), pos.z); // Posici�n ajustada.

            // Aplica la correcci�n de posici�n.
            state.PositionCorrection += pos2 - pos;
        }
    }

    // Redondea una posici�n dada seg�n los p�xeles por unidad.
    float Round(float x)
    {
        return Mathf.Round(x * PixelsPerUnit) / PixelsPerUnit;
    }
}
