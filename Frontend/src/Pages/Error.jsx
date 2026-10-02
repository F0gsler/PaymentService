import '../App.css'
import { useNavigate } from 'react-router-dom'
import { useState } from 'react'


export default function Error() {

  const navigate = useNavigate()
  const AdminLevel = 0

  return (
    <>
        <div className="HomeContent">
            <h2 id="homeHeader">Velkommen til Marius Bio</h2>
            <p id="homeText">Se alle de fantasiske film vi har på programmet</p>
            <button id="CommonButton" onClick={() => navigate('/program')}>Se program</button>
            <button id="CommonButton" onClick={() => setShowPopup(!showPopup)}>Kontakt Info</button>
            <div>
            {AdminLevel === 0 && <button id="CommonButton" onClick={() => navigate('/admin')}>Admin Page</button>}


            </div>
        </div>
    </>
  )
}