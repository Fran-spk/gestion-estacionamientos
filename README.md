# Sistema de Gestión de Estacionamientos

## Descripción General

Sistema de gestión de estacionamientos desarrollado en C# con arquitectura en capas, diseñado para administrar de forma integral el flujo operativo de un estacionamiento: ingresos y egresos de vehículos, tarifas, servicios adicionales, planes mensuales, pagos, auditoría y resguardo de datos.

El sistema contempla dos modalidades de estacionamiento: ticket diario con cálculo automático por horas, media hora o día completo, y planes mensuales con cuotas y servicios adicionales asociados. Ambas modalidades comparten el módulo de pagos, reportes y seguridad.

---

## Características Principales

### Gestión de vehículos y tickets
- Registro de ingreso y egreso de vehículos con validación de presencia activa.
- Generación de tickets diarios con cálculo automático de estadía por horas, media hora o día completo.
- Detección y actualización automática de tickets vencidos al iniciar operaciones.
- Auditoría completa de cada ticket: creación, cambios de estado y servicios asignados o quitados.

### Servicios adicionales
- Asignación de servicios adicionales a tickets diarios y planes mensuales.
- Cálculo de tiempo estimado de demora basado en la cantidad de vehículos con el mismo servicio pendiente.
- Gestión individual o masiva de servicios: asignar, quitar y liquidar.
- Historial de servicios por estado: pendiente, pagado y anulado.

### Planes mensuales
- Alta y gestión de planes con cuotas mensuales.
- Descuentos configurables por plan aplicados automáticamente al calcular el monto.
- Servicios adicionales independientes de las cuotas, con posibilidad de liquidarlos en conjunto o por separado.
- Visualización del número de cuota dentro del plan (ejemplo: Cuota 3 de 6).

### Pagos
- Cuatro flujos de pago soportados: solo cuota, cuota con servicios, ticket diario con servicios y solo servicios del plan.
- Patrón Factory para construcción centralizada y consistente de pagos.
- Patrón Strategy para cálculo de montos según modalidad: horas, día, mensual o servicio.
- Validación de permisos de usuario antes de procesar cualquier pago.
- Generación automática de recibos con tres formatos según el tipo de pago.

### Recibos
- Patrón Strategy para generación de recibos: ticket diario, cuota mensual y solo servicios.
- Vista previa de impresión con diseño de ticket físico adaptado al contenido.
- Cálculo dinámico del largo del papel según la cantidad de líneas del recibo.

### Seguridad y usuarios
- Sistema de roles con grupos, módulos, formularios y acciones.
- Permisos granulares por acción dentro de cada formulario.
- Asignación de permisos individuales o heredados desde grupos.
- Generación automática de contraseña inicial al crear un usuario.
- Validación centralizada de permisos mediante `PermisoService`.

### Auditoría
- Registro de todas las operaciones sobre tickets: creación, cambio de estado, alta y baja de servicios.
- Historial consultable por ticket individual o global.
- Trazabilidad completa para soporte operativo y control administrativo.

### Resguardo y recuperación
- Generación de backup de la base de datos con sobreescritura del archivo anterior.
- Restauración de la base de datos desde el último backup con cierre y reinicio automático de la aplicación.
- Indicación visual de la fecha y hora del último backup realizado.

### Reportes
- Generación de reportes administrativos en PDF con tablas, resúmenes ejecutivos y gráficos estadísticos.
- Exportación de movimientos, ingresos por período y ocupación del estacionamiento.

### Tarifas
- Gestión de tarifas de estacionamiento y servicios por tipo de vehículo.
- Historial de tarifas con vigencia: los cambios generan nuevas tarifas sin eliminar el historial.
- Tiempo estimado de atención configurable por tipo de servicio y vehículo.

---

## Arquitectura

El sistema está organizado en cuatro capas con dependencias unidireccionales:
```
Vista → Servicios → Modelo
Vista → Controladora → Modelo
Controladora → Base de datos (EF Core)
```

- **Vista**: formularios WinForms. No accede a la base de datos directamente.
- **Servicios**: lógica de negocio pura sin acceso a datos. Recibe todo por parámetro. Incluye `ReciboService`, `EstadiaService`, `BackupService` y `PermisoService`.
- **Controladora**: único punto de acceso a la base de datos. Todas las controladoras son Singleton.
- **Modelo**: entidades del dominio, patrones de cálculo (Strategy), construcción de pagos (Factory) y contexto EF Core.

---

## Patrones de Diseño Aplicados

| Patrón | Ubicación | Propósito |
|---|---|---|
| Strategy | `CalculadorPago` y subclases | Cálculo de montos según modalidad de pago |
| Strategy | `IGeneradorRecibo` y subclases | Generación de recibos según tipo de pago |
| Factory Method | `PagoFactory` | Construcción centralizada de los 4 flujos de pago |
| Singleton | Todas las controladoras y `Sesion` | Instancia única de acceso a datos y sesión |

---

## Tecnologías Utilizadas

- C# .NET 6 o superior
- Windows Forms (WinForms)
- Entity Framework Core
- SQL Server
- iTextSharp / biblioteca PDF para generación de reportes
- PrintDocument para impresión de recibos

---

## Requisitos

- .NET 6 SDK o superior
- SQL Server 2019 o superior
- Visual Studio 2022 recomendado
- Permisos de escritura en la carpeta del ejecutable para generación de backups

---

## Configuración Inicial

1. Clonar el repositorio.
2. Configurar el string de conexión en el archivo de contexto apuntando a la instancia de SQL Server.
3. Aplicar las migraciones de Entity Framework Core.
4. Ejecutar la aplicación. En el primer inicio crear el usuario administrador desde la gestión de usuarios.
5. Configurar tarifas de estacionamiento y servicios antes de comenzar a operar.
