import '../App.css'
import Navbar from '../Components/Navbar.jsx'
import { useNavigate } from 'react-router-dom'
import { useState } from 'react'



export default function Home() {

  const navigate = useNavigate()

  return (
    <>
        <Navbar />
        
        <div>
            
        </div>
    </>
  )
}