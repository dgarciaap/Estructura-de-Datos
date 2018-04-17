/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package tarjeta;

/**
 *
 * @author Diana
 */
public class Producto {
    private int numeroRegistro;
    private String nombre;
    private float costo;
    private int puntos;
    
    public Producto(String nombre, String costo, String puntos, int numeroRegistro){
        this(nombre, costo, puntos);
        this.numeroRegistro = numeroRegistro;
    }
    
    public Producto(String nombre, float costo, int puntos) {
        this.nombre = nombre;
        this.costo = costo;
        this.puntos = puntos;
    }
    
    public Producto(String nombre, String costo, String puntos) {
        this.nombre = nombre;
        this.costo = Float.valueOf(costo);
        this.puntos = Integer.valueOf(puntos);
    }

    /**
     * @return the nombre
     */
    public String getNombre() {
        return nombre;
    }

    /**
     * @param nombre the nombre to set
     */
    public void setNombre(String nombre) {
        this.nombre = nombre;
    }

    /**
     * @return the costo
     */
    public float getCosto() {
        return costo;
    }

    /**
     * @param costo the costo to set
     */
    public void setCosto(float costo) {
        this.costo = costo;
    }

    /**
     * @return the puntos
     */
    public int getPuntos() {
        return puntos;
    }

    /**
     * @param puntos the puntos to set
     */
    public void setPuntos(int puntos) {
        this.puntos = puntos;
    }
    
    /**
     * @return the numeroRegistro
     */
    public int getNumeroRegistro() {
        return numeroRegistro;
    }

    /**
     * @param numeroRegistro the numeroRegistro to set
     */
    public void setNumeroRegistro(int numeroRegistro) {
        this.numeroRegistro = numeroRegistro;
    }
}
