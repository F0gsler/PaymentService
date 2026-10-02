import '../App.css'
import { useNavigate } from 'react-router-dom'
import { useState } from 'react'


export default function Navbar() {

  const navigate = useNavigate()
  const AdminLevel = 0

  return (
    <>
        <div className="Navbar ">
            <div className="NavbarLeft">
            <h2 id="homeHeader">Mripe</h2>
            </div>
            <div className="NavbarRight">
            <button className="CommonButton" onClick={() => navigate('/program')}>Se program</button>
            {AdminLevel === 0 && <button className="CommonButton" onClick={() => navigate('/admin')}>Admin Page</button>}

            </div>
        </div>
    </>
  )
}