import '../App.css'
import Navbar from '../Components/Navbar.jsx'
import { useNavigate } from 'react-router-dom'
import { useState } from 'react'



export default function Home() {

  const [adminLevel, setAdminLevel] = useState(false)
  const [username, setUsername] = useState('')
  const [password, setPassword] = useState('')
  const [besked, setBesked] = useState('')



  const navigate = useNavigate()

  const createAdminUser = async () => {
    try {
      const res = await fetch(`/api/Admin/createAdminUser`, {
        method: 'POST',
        headers: { 'Content-Type': 'application/json' },
        body: JSON.stringify({
          username: username,
          password: password,
          adminLevel: adminLevel,
        }),
      })

      const data = await res.json()
      setBesked(`Oprettet: ${data.username}`)
    } catch (err) {
      setBesked(`Fejl: ${err.message}`)
    }
  }

  return (
    <>
      <Navbar />
      <main className="home-page">
        <nav className="home-actions" aria-label="Hurtiglinks">
          <button className="CommonButton" onClick={() => navigate('/login')}>Login</button>
          <button className="CommonButton" onClick={() => navigate('/admin')}>Admin Page</button>
        </nav>

        <section className="admin-card">
          <h1>Opret administrator</h1>
          <p className="admin-card-description">Udfyld oplysningerne for at oprette en ny bruger.</p>
          <input type="text" value={username} onChange={(e) => setUsername(e.target.value)} placeholder="Brugernavn" aria-label="Brugernavn" />
          <input type="password" value={password} onChange={(e) => setPassword(e.target.value)} placeholder="Adgangskode" aria-label="Adgangskode" />
          <button className="admin-level-button" onClick={() => setAdminLevel(!adminLevel)}>
            Adminrettigheder: {adminLevel ? 'Til' : 'Fra'}
          </button>
          <button className="create-admin-button" onClick={createAdminUser}>Opret bruger</button>
          {besked && <p className="admin-message" role="status">{besked}</p>}
        </section>
      </main>
    </>
  )
}